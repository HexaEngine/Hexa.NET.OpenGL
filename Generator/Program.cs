using Generator;
using HexaGen;
using HexaGen.Metadata;
using HexaGen.Patching;
using System.Text;
using System.Xml.Serialization;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
string headerFile = "include/main.h";

string outputPath = "../../../../Hexa.NET.OpenGL/Generated";

XmlSerializer serializer = new(typeof(GlRegistry));

using var fs = File.OpenRead("gl.xml");
GlRegistry registry = (GlRegistry)serializer.Deserialize(fs)!;

bool generateAll = false; // only for generation testing.

string featureTarget = "GL_VERSION_3_3";
bool compatibility = false;

HashSet<string> usedEnums = [];
HashSet<string> usedCommands = [];

foreach (var feature in registry.Features)
{
    foreach (var require in feature.Require)
    {
        if (require.Profile == "core" && compatibility)
        {
            continue;
        }

        if (require.Profile == "compatibility" && !compatibility)
        {
            continue;
        }

        foreach (var @enum in require.Enums)
        {
            usedEnums.Add(@enum.Name);
        }

        foreach (var command in require.Commands)
        {
            usedCommands.Add(command.Name);
        }
    }

    foreach (var remove in feature.Remove)
    {
        if (remove.Profile == "core" && compatibility)
        {
            continue;
        }

        if (remove.Profile == "compatibility" && !compatibility)
        {
            continue;
        }

        foreach (var @enum in remove.Enums)
        {
            usedEnums.Remove(@enum.Name);
        }

        foreach (var command in remove.Commands)
        {
            usedCommands.Remove(command.Name);
        }
    }

    if (feature.Name == featureTarget)
    {
        break;
    }
}

Dictionary<string, List<Generator.Enum>> groups = [];
Dictionary<string, string> groupToEnumName = [];

CsEnumMetadata glEnum = new("GLEnum", "GLEnum", [], null);
EnumPrefix prefixGl = config.GetEnumNamePrefixEx("GL_");
foreach (var enumGroup in registry.EnumGroups)
{
    foreach (var @enum in enumGroup.Items)
    {
        if (!usedEnums.Contains(@enum.Name) && !generateAll)
        {
            continue;
        }

        if (enumGroup.StartString != null && enumGroup.EndString != null)
        {
            string csEnumItemName = config.GetEnumName(@enum.Name, prefixGl);
            CsEnumItemMetadata csEnumItem = new(@enum.Name, @enum.Value, csEnumItemName, @enum.Value, [], null);
            glEnum.Items.Add(csEnumItem);
        }

        foreach (var group in @enum.GroupList)
        {
            if (!groups.TryGetValue(group, out var enums))
            {
                enums = []; // valid before you ask C#12/net8.0.
                groups.Add(group, enums);
            }

            enums.Add(@enum);
        }
    }
}
config.CustomEnums.Add(glEnum);

foreach (var pair in groups)
{
    string enumName = "GL" + config.GetCsCleanName(pair.Key);
    EnumPrefix prefix = config.GetEnumNamePrefixEx(pair.Key);
    Array.Resize(ref prefix.Parts, prefix.Parts.Length + 1);
    prefix.Parts[^1] = "Gl";

    groupToEnumName.Add(pair.Key, enumName);

    CsEnumMetadata metadata = new(pair.Key, enumName, [], null);
    metadata.BaseType = "uint";

    if (enumName == "GLSpecialNumbers")
    {
        metadata.BaseType = "ulong";
    }

    foreach (var item in pair.Value)
    {
        string csEnumItemName = config.GetEnumName(item.Name, prefix);
        CsEnumItemMetadata csEnumItem = new(item.Name, item.Value, csEnumItemName, $"unchecked(({metadata.BaseType}){item.Value})", [], null);
        metadata.Items.Add(csEnumItem);
    }
    config.CustomEnums.Add(metadata);
}

string functionsOutputPath = Path.Combine(outputPath, "Functions");

if (Directory.Exists(functionsOutputPath))
{
    Directory.Delete(functionsOutputPath, true);
}
Directory.CreateDirectory(functionsOutputPath);

FunctionTableBuilder functionTableBuilder = new();
CsSplitCodeWriter writer = new(Path.Combine(functionsOutputPath, "Functions.cs"), config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics"], null);
writer.BeginBlock("public static unsafe partial class GL");
foreach (var command in registry.Commands)
{
    string name = command.Proto.Name;

    if (!usedCommands.Contains(name) && !generateAll)
    {
        continue;
    }

    if (name.StartsWith("gl"))
    {
        name = name[2..];
    }

    string? returnType = command.Proto.PType?.Trim();

    {
        if (returnType != null)
        {
            if (config.TypeMappings.TryGetValue(returnType, out var newType))
            {
                returnType = newType;
            }
        }

        if (command.Proto.Prefix == "void")
        {
            returnType = "void";
        }
        else
        {
            if (command.Proto.Prefix == null || command.Proto.Prefix == "const" || command.Proto.Prefix == "struct")
            {
                returnType = $"{returnType}{command.Proto.Postfix}";
            }
            else
            {
                returnType = $"{command.Proto.Prefix} {returnType}{command.Proto.Postfix}";
            }
        }
    }

    StringBuilder sb = new();
    StringBuilder sbNameless = new();
    StringBuilder sbParam = new();

    bool first = true;
    bool faulty = false;
    for (int i = 0; i < command.Params.Count; i++)
    {
        Param param = command.Params[i];
        var type = param.Type;

        if (type == null)
        {
            faulty = true;
            break;
        }

        var paramName = config.GetParameterName(i, param.Name);

        if (param.Group != null)
        {
            type = groupToEnumName[param.Group];
        }

        {
            if (config.TypeMappings.TryGetValue(type, out var newType))
            {
                type = newType;
            }
        }

        if (first)
        {
            sb.Append($"{type} {paramName}");
            sbNameless.Append(type);
            sbParam.Append(paramName);
            first = false;
        }
        else
        {
            sb.Append($", {type} {paramName}");
            sbNameless.Append($", {type}");
            sbParam.Append($", {paramName}");
        }
    }
    if (faulty)
    {
        continue;
    }

    int idx = functionTableBuilder.Add(command.Proto.Name);

    if (first)
    {
        sbNameless.Append(returnType);
    }
    else
    {
        sbNameless.Append($", {returnType}");
    }

    string paramSignatureNameless = sbNameless.ToString();
    string delegateSig;
    if (returnType != "void")
    {
        delegateSig = $"{returnType} ret = ((delegate* unmanaged[Cdecl]<{paramSignatureNameless}>)funcTable[{idx}])({sbParam});";
    }
    else
    {
        delegateSig = $"((delegate* unmanaged[Cdecl]<{paramSignatureNameless}>)funcTable[{idx}])({sbParam});";
    }

    string paramSignature = sb.ToString();
    string csSig = $"public static {returnType} {name}({paramSignature})";

    writer.BeginBlock(csSig);
    writer.WriteLine(delegateSig);
    if (returnType != "void")
    {
        writer.WriteLine("return ret;");
    }
    writer.EndBlock();
    writer.WriteLine();
}
writer.EndBlock();
writer.Dispose();

var tableWriter = new CsCodeWriter("FunctionTable.cs", config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics"], null);

var initString = functionTableBuilder.Finish(out var count);
string filePathfuncTable = Path.Combine(outputPath, "FunctionTable.cs");
using var writerfuncTable = new CsCodeWriter(filePathfuncTable, config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics"], config.HeaderInjector);
using (writerfuncTable.PushBlock($"public unsafe partial class {config.ApiName}"))
{
    writerfuncTable.WriteLine("internal static FunctionTable funcTable;");
    writerfuncTable.WriteLine();
    writerfuncTable.WriteLine("/// <summary>");
    writerfuncTable.WriteLine("/// Initializes the function table, automatically called. Do not call manually, only after <see cref=\"FreeApi\"/>.");
    writerfuncTable.WriteLine("/// </summary>");

    if (config.UseCustomContext)
    {
        using (writerfuncTable.PushBlock("public static void InitApi(INativeContext context)"))
        {
            writerfuncTable.WriteLine($"funcTable = new FunctionTable(context, {count});");
            writerfuncTable.WriteLines(initString);
        }
    }
    else
    {
        using (writerfuncTable.PushBlock("public static void InitApi()"))
        {
            writerfuncTable.WriteLine($"funcTable = new FunctionTable(LibraryLoader.LoadLibrary({config.GetLibraryNameFunctionName}, {config.GetLibraryExtensionFunctionName ?? "null"}), {count});");
            writerfuncTable.WriteLines(initString);
        }
    }
    writerfuncTable.WriteLine();
    using (writerfuncTable.PushBlock("public static void FreeApi()"))
    {
        writerfuncTable.WriteLine("funcTable.Free();");
    }
}

CsCodeGenerator generator = new(config);
generator.LogToConsole();
generator.Generate(headerFile, outputPath);