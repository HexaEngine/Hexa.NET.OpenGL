using Generator;
using HexaGen;
using HexaGen.Core;
using HexaGen.Core.CSharp;
using HexaGen.Metadata;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

internal class Program
{
    private static readonly LoggerBase logger = new();
    private static readonly ConfigComposer composer = new();

    public static readonly CsType StringType = new("byte*", CsPrimitiveType.Byte) { StringType = CsStringType.StringUTF8 };
    public static GlRefPages pages = new();

    private static void Main(string[] args)
    {
        var start = DateTime.Now;

        pages.Parse("gl4");

        XmlSerializer serializer = new(typeof(GlRegistry));
        using var fs = File.OpenRead("gl.xml");
        GlRegistry registry = (GlRegistry)serializer.Deserialize(fs)!;

        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.base.json");

        var groupToEnumName = GenerateEnums(config, registry, "gl");
        {
            CsCodeGenerator generator = new(config);
            generator.LogToConsole();
            generator.Generate("include/main.h", "../../../../Hexa.NET.OpenGL.Core/Generated");
        }

        CsCodeGeneratorConfig configEs = CsCodeGeneratorConfig.Load("es/generator.base.json");

        var groupToEnumNameEs = GenerateEnums(configEs, registry, "gles2");
        {
            CsCodeGenerator generator = new(configEs);
            generator.LogToConsole();
            generator.Generate("include/main.h", "../../../../Hexa.NET.OpenGLES.Core/Generated");
        }
        logger.LogToConsole();

        Generate(registry, "generator.json", "GL_VERSION_2_1", compatibility: false, false, "../../../../Hexa.NET.OpenGL2/Generated", config.CustomEnums, groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_3_3", compatibility: false, false, "../../../../Hexa.NET.OpenGL3/Generated", config.CustomEnums, groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_4_6", compatibility: false, false, "../../../../Hexa.NET.OpenGL4/Generated", config.CustomEnums, groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_3_3", compatibility: true, false, "../../../../Hexa.NET.OpenGL3.Compat/Generated", config.CustomEnums, groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_4_6", compatibility: true, false, "../../../../Hexa.NET.OpenGL4.Compat/Generated", config.CustomEnums, groupToEnumName);
        Generate(registry, "es/generator.json", "GL_ES_VERSION_2_0", compatibility: false, false, "../../../../Hexa.NET.OpenGLES2/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        Generate(registry, "es/generator.json", "GL_ES_VERSION_3_2", compatibility: false, false, "../../../../Hexa.NET.OpenGLES3/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "generator.ext.json", "GL_EXT", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.EXT/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.arb.json", "GL_ARB", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.ARB/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.nv.json", "GL_NV", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.NV/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.amd.json", "GL_AMD", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.AMD/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.apple.json", "GL_APPLE", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.APPLE/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.intel.json", "GL_INTEL", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.INTEL/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.khr.json", "GL_KHR", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.KHR/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.mesa.json", "GL_MESA", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.MESA/Generated", config.CustomEnums, groupToEnumName);
        GenerateExtension(registry, "generator.ovr.json", "GL_OVR", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.OVR/Generated", config.CustomEnums, groupToEnumName);

        GenerateExtension(registry, "es/generator.android.json", "GL_ANDROID", ["gles2"], "../../../../Hexa.NET.OpenGLES.ANDROID/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.ext.json", "GL_EXT", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.EXT/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.amd.json", "GL_AMD", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.AMD/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.angle.json", "GL_ANGLE", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.ANGLE/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.arm.json", "GL_ARM", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.ARM/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.intel.json", "GL_INTEL", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.INTEL/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.khr.json", "GL_KHR", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.KHR/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.mesa.json", "GL_MESA", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.MESA/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.nv.json", "GL_NV", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.NV/Generated", configEs.CustomEnums, groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.oes.json", "GL_OES", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.OES/Generated", configEs.CustomEnums, groupToEnumNameEs, true);

        var end = DateTime.Now;
        var elapsed = end - start;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"All Done! Generation took {elapsed.TotalSeconds:n2}s");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static readonly HashSet<string> acceptedExtensions = ["GL_EXT", "GL_ARB", "GL_NV", "GL_AMD", "GL_APPLE", "GL_INTEL", "GL_KHR", "GL_MESA", "GL_OVR"];
    public static readonly HashSet<string> acceptedExtensionsEs = ["GL_ANDROID", "GL_EXT", "GL_AMD", "GL_ANGLE", "GL_ARM", "GL_INTEL", "GL_KHR", "GL_MESA", "GL_NV", "GL_OES"];

    private static void Generate(GlRegistry registry, string configPath, string featureTarget, bool compatibility, bool generateAll, string outputPath, List<CsEnumMetadata> customEnums, Dictionary<string, string> groupToEnumName, bool es = false)
    {
        string functionsOutputPath = Path.Combine(outputPath, "Functions");

        if (Directory.Exists(functionsOutputPath))
        {
            Directory.Delete(functionsOutputPath, true);
        }
        Directory.CreateDirectory(functionsOutputPath);

        logger.LogInfo($"Generating {featureTarget} ...");
        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load(configPath);

        config.CustomEnums.AddRange(customEnums);

        composer.Compose(config);

        GatherUsedTargets(registry, featureTarget, compatibility, out _, out HashSet<string> usedCommands);
        FunctionTableBuilder functionTableBuilder = new();
        using CsSplitCodeWriter writer = new(Path.Combine(functionsOutputPath, "Functions.cs"), config.Namespace, ["System", "HexaGen.Runtime", "System.Runtime.CompilerServices", "System.Numerics"], null);

        writer.BeginBlock($"public static unsafe partial class {config.ApiName}");
        WriteFunctions(writer, config, outputPath, registry, generateAll, usedCommands, groupToEnumName, functionTableBuilder, es);
        writer.EndBlock();

        WriteFunctionTable(config, Path.Combine(outputPath, "FunctionTable.cs"), functionTableBuilder);
        logger.LogInfo($"Done Generating {featureTarget} ...");
    }

    private static void GenerateExtension(GlRegistry registry, string configPath, string extensionTarget, HashSet<string> apiTargets, string outputPath, List<CsEnumMetadata> customEnums, Dictionary<string, string> groupToEnumName, bool es = false)
    {
        string functionsOutputPath = Path.Combine(outputPath, "Functions");

        if (Directory.Exists(functionsOutputPath))
        {
            Directory.Delete(functionsOutputPath, true);
        }
        Directory.CreateDirectory(functionsOutputPath);

        logger.LogInfo($"Generating {extensionTarget} ...");
        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load(configPath);

        config.CustomEnums.AddRange(customEnums);

        composer.Compose(config);

        foreach (var (extensionName, originalName, _, usedCommands) in GatherUsedTargetsForExtension(registry, extensionTarget, apiTargets))
        {
            WriteExtension(registry, outputPath, groupToEnumName, es, functionsOutputPath, config, originalName, extensionName, usedCommands);
        }

        logger.LogInfo($"Done Generating {extensionTarget} ...");
    }

    private static void WriteExtension(GlRegistry registry, string outputPath, Dictionary<string, string> groupToEnumName, bool es, string functionsOutputPath, CsCodeGeneratorConfig config, string originalExtensionName, string extensionName, HashSet<string> usedCommands)
    {
        if (usedCommands.Count == 0) return;
        logger.LogInfo($"Generating {extensionName} ...");
        config.ApiName = extensionName;
        FunctionTableBuilder functionTableBuilder = new();
        using CsSplitCodeWriter writer = new(Path.Combine(functionsOutputPath, $"{extensionName}.cs"), config.Namespace, ["System", "HexaGen.Runtime", "System.Runtime.CompilerServices", "System.Numerics"], null);

        writer.BeginBlock($"public static unsafe partial class {config.ApiName}");
        WriteFunctions(writer, config, outputPath, registry, false, usedCommands, groupToEnumName, functionTableBuilder, es);
        writer.EndBlock();

        WriteFunctionTableForExtension(config, Path.Combine(functionsOutputPath, $"{extensionName}.FN.cs"), functionTableBuilder, originalExtensionName, es ? "Hexa.NET.OpenGLES" : "Hexa.NET.OpenGL", "GLBase");
        logger.LogInfo($"Done Generating {extensionName} ...");
    }

    private static void WriteVariations(ICodeWriter writer, string returnType, Overload overload)
    {
        Parameter[] parameters = overload.Parameters;
        long maxVariations = (long)Math.Pow(2L, parameters.Length);
        HashSet<Overload> defs = [overload];
        for (long ix = 1; ix < maxVariations; ix++)
        {
            Parameter[] stringVariation = new Parameter[parameters.Length];
            Parameter[] spanVariation = new Parameter[parameters.Length];
            Parameter[] refVariation = new Parameter[parameters.Length];
            Parameter[] voidVariation = new Parameter[parameters.Length];
            Parameter[] voidSpanVariation = new Parameter[parameters.Length];

            Overload stringOverload = overload.CreateVariation(stringVariation);
            Overload spanOverload = overload.CreateVariation(spanVariation);
            Overload refOverload = overload.CreateVariation(refVariation);
            Overload voidOverload = overload.CreateVariation(voidVariation);
            Overload voidSpanOverload = overload.CreateVariation(voidSpanVariation);

            for (int j = 0; j < parameters.Length; j++)
            {
                var bit = (ix & 1 << j - 64) != 0;

                Parameter parameter = parameters[j];

                if (bit)
                {
                    if (parameter.Type == "void*")
                    {
                        voidVariation[j] = new(parameter.Name, "nint") { IsVoid = true };
                        string genericType = $"T{parameter.Name.CapitalizeCopy()}"; // parameter names have to be unique so it's fine to use them as generic too with T prefix.
                        voidSpanOverload.Generics.Add(new(genericType, $"where {genericType} : unmanaged"));
                        voidSpanVariation[j] = new(parameter.Name, $"Span<{genericType}>") { IsGeneric = true, IsSpan = true, GenericType = genericType };
                    }
                    else
                    {
                        voidSpanVariation[j] = voidVariation[j] = parameter;
                    }

                    if (parameter.Type == "byte*")
                    {
                        stringVariation[j] = new(parameter.Name, "string") { IsString = true };
                        spanVariation[j] = new(parameter.Name, "ReadOnlySpan<byte>") { IsSpan = true };
                    }
                    else
                    {
                        spanVariation[j] = stringVariation[j] = parameter;
                    }

                    var pointerDepth = parameter.Type.AsSpan().Count('*');
                    if (pointerDepth == 1 && parameter.Type != "void*" && !parameter.IsOut)
                    {
                        var cleanName = parameter.Type.Replace("*", string.Empty);
                        refVariation[j] = new(parameter.Name, $"ref {cleanName}") { IsRef = true };
                        spanVariation[j] = new(parameter.Name, $"Span<{cleanName}>") { IsSpan = true };
                    }
                    else
                    {
                        refVariation[j] = parameter;
                    }
                }
                else
                {
                    voidSpanVariation[j] = voidVariation[j] = refVariation[j] = spanVariation[j] = stringVariation[j] = parameter;
                }
            }

            WriteFunction(returnType, overload.Name, parameters, writer, defs, stringOverload);
            WriteFunction(returnType, overload.Name, parameters, writer, defs, spanOverload);
            WriteFunction(returnType, overload.Name, parameters, writer, defs, refOverload);
            WriteFunction(returnType, overload.Name, parameters, writer, defs, voidOverload);
            WriteFunction(returnType, overload.Name, parameters, writer, defs, voidSpanOverload);
        }
    }

    private static void WriteFunction(string returnType, string name, Parameter[] rootParameters, ICodeWriter writer, HashSet<Overload> defs, Overload variation)
    {
        foreach (var def in defs)
        {
            if (def.IsSame(variation))
            {
                return;
            }
        }

        defs.Add(variation);

        StringBuilder sb = new();
        StringBuilder sbNameless = new();
        StringBuilder sbParam = new();
        bool first = true;

        int blocks = 0;
        int stringIdx = 0;
        List<(string name, string fixedName, string type, int index)> fixedStack = [];
        List<(string name, int index)> stringStack = [];
        for (int i = 0; i < variation.Parameters.Length; i++)
        {
            var parameter = variation[i];
            var paramName = parameter.Name;
            var paramType = parameter.Type;

            string paramListName = paramName;

            if (parameter.IsString)
            {
                stringStack.Add((paramName, stringIdx));
                paramListName = $"pStr{stringIdx}";
                stringIdx++;
            }

            if (parameter.IsSpan || parameter.IsRef)
            {
                if (parameter.IsGeneric)
                {
                    paramListName = $"p{paramName.Replace("@", string.Empty)}{fixedStack.Count}";
                    fixedStack.Add((paramName, paramListName, $"{parameter.GenericType!}*", i));
                }
                else
                {
                    paramListName = $"p{paramName.Replace("@", string.Empty)}{fixedStack.Count}";
                    fixedStack.Add((paramName, paramListName, rootParameters[i].Type, i));
                }
            }

            if (!first)
            {
                sb.Append(", ");
                sbParam.Append(", ");
                sbNameless.Append(", ");
            }
            first = false;

            if (paramType == "nint" && parameter.IsVoid)
            {
                sbParam.Append($"(void*){paramListName}");
            }
            else
            {
                sbParam.Append(paramListName);
            }

            sb.Append($"{paramType} {paramName}");
            sbNameless.Append(paramType);
        }

        string paramSignatureNameless = sbNameless.ToString();

        if (first)
        {
            sbNameless.Append(returnType);
        }
        else
        {
            sbNameless.Append($", {returnType}");
        }

        string delegateSig;
        if (returnType != "void")
        {
            delegateSig = $"{returnType} ret = {name}Native({sbParam});";
        }
        else
        {
            delegateSig = $"{name}Native({sbParam});";
        }

        bool isBool = returnType == "byte";

        string genericsString = variation.Generics.Count == 0 ? string.Empty : $"<{string.Join(", ", variation.Generics.Select(x => x.Name))}>";
        string genericsConstrain = variation.Generics.Count == 0 ? string.Empty : $" {string.Join(" ", variation.Generics.Select(x => x.Constrain))}";

        string functionSignatureApi = $"{(isBool ? "bool" : returnType)} {name}{genericsString}({sb}){genericsConstrain}";
        logger.LogInfo($"defined {functionSignatureApi}");

        string functionHeader = $"public static {functionSignatureApi}";

        writer.WriteLines(variation.Comment);
        writer.BeginBlock(functionHeader);

        foreach (var str in stringStack)
        {
            MarshalHelper.WriteStringConvertToUnmanaged(writer, StringType, str.name, str.index);
        }

        foreach (var fx in fixedStack)
        {
            if (variation[fx.index].Type.Contains("ref"))
            {
                writer.BeginBlock($"fixed ({fx.type} {fx.fixedName} = &{fx.name})");
            }
            else
            {
                writer.BeginBlock($"fixed ({fx.type} {fx.fixedName} = {fx.name})");
            }

            blocks++;
        }

        writer.WriteLine(delegateSig);

        foreach (var str in stringStack)
        {
            MarshalHelper.WriteFreeString(writer, str.index);
        }

        if (returnType != "void")
        {
            if (isBool)
            {
                writer.WriteLine("return ret != 0;");
            }
            else
            {
                writer.WriteLine("return ret;");
            }
        }

        for (int i = 0; i < blocks; i++)
        {
            writer.EndBlock();
        }

        writer.EndBlock();
        writer.WriteLine();
    }

    private static string ParseType(CsCodeGeneratorConfig config, IGlType type)
    {
        type.Prefix = type.Prefix?.Replace("const", string.Empty)?.Trim()!;
        type.PType = type.PType?.Replace("const", string.Empty)?.Trim()!;
        type.Postfix = type.Postfix?.Replace("const", string.Empty)?.Trim()!;

        string? result = type.PType;

        {
            if (result != null)
            {
                if (config.TypeMappings.TryGetValue(result, out var newType))
                {
                    result = newType;
                }
            }

            if (type.Prefix == "void")
            {
                result = "void";
            }
            else
            {
                if (type.Prefix == null || type.Prefix == "const" || type.Prefix == "struct")
                {
                    result = $"{result}{type.Postfix}";
                }
                else
                {
                    result = $"{type.Prefix}{result}{type.Postfix}";
                }
            }
        }

        return result.Replace(" ", string.Empty);
    }

    private static void GatherUsedTargets(GlRegistry registry, string featureTarget, bool compatibility, out HashSet<string> usedEnums, out HashSet<string> usedCommands)
    {
        bool es = false;
        if (featureTarget.Contains("GL_VERSION_ES"))
        {
            es = true;
        }
        usedEnums = [];
        usedCommands = [];
        foreach (var feature in registry.Features)
        {
            if (es && !feature.Name.Contains("GL_VERSION_ES"))
            {
                continue;
            }

            foreach (var require in feature.Require)
            {
                if (require.Profile != null)
                {
                    if (require.Profile == "core" && compatibility)
                    {
                        continue;
                    }

                    if (require.Profile == "compatibility" && !compatibility)
                    {
                        continue;
                    }
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
                if (remove.Profile != null)
                {
                    if (remove.Profile == "core" && compatibility)
                    {
                        continue;
                    }

                    if (remove.Profile == "compatibility" && !compatibility)
                    {
                        continue;
                    }
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
    }

    private static IEnumerable<(string extensionName, string originalName, HashSet<string> usedEnums, HashSet<string> usedCommands)> GatherUsedTargetsForExtension(GlRegistry registry, string featureTarget, HashSet<string> apiTargets)
    {
        HashSet<string> androidTarget = [
            "GL_KHR_debug",
            "GL_KHR_texture_compression_astc_ldr",
            "GL_KHR_blend_equation_advanced",
            "GL_OES_sample_shading",
            "GL_OES_sample_variables",
            "GL_OES_shader_image_atomic",
            "GL_OES_shader_multisample_interpolation",
            "GL_OES_texture_stencil8",
            "GL_OES_texture_storage_multisample_2d_array",
            "GL_EXT_copy_image",
            "GL_EXT_draw_buffers_indexed",
            "GL_EXT_geometry_shader",
            "GL_EXT_gpu_shader5",
            "GL_EXT_primitive_bounding_box",
            "GL_EXT_shader_io_blocks",
            "GL_EXT_tessellation_shader",
            "GL_EXT_texture_border_clamp",
            "GL_EXT_texture_buffer",
            "GL_EXT_texture_cube_map_array",
            "GL_EXT_texture_srgb_decode",
            ];
        HashSet<string> usedEnums = [];
        HashSet<string> usedCommands = [];
        foreach (var extension in registry.Extensions.Extension)
        {
            usedEnums.Clear();
            usedCommands.Clear();

            if (featureTarget == "GL_ANDROID")
            {
                if (!androidTarget.Contains(extension.Name))
                {
                    continue;
                }
            }
            else if (!extension.Name.StartsWith(featureTarget))
            {
                continue;
            }

            if (!extension.SupportedList.Any(apiTargets.Contains))
            {
                continue;
            }

            string nameFormatted = string.Join(string.Empty, extension.Name.Split('_', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(Capitalize));

            foreach (var require in extension.Require)
            {
                foreach (var @enum in require.Enums)
                {
                    usedEnums.Add(@enum.Name);
                }

                foreach (var command in require.Commands)
                {
                    usedCommands.Add(command.Name);
                }
            }

            yield return (nameFormatted, extension.Name, usedEnums, usedCommands);
        }
    }

    private static unsafe string Capitalize(string x)
    {
        if (x.Length == 0) return x;

        fixed (char* px = x)
        {
            px[0] = char.ToUpper(px[0]);
        }

        return x;
    }

    private static Dictionary<string, string> GenerateEnums(CsCodeGeneratorConfig config, GlRegistry registry, string apiTarget)
    {
        Dictionary<string, List<Generator.Enum>> groups = [];
        Dictionary<string, string> groupToEnumName = [];
        Dictionary<string, Generator.Enum> nameToEnum = [];
        List<Generator.Enum> globalEnums = new();

        CsEnumMetadata glEnum = new("GLEnum", "GLEnum", [], null);
        EnumPrefix prefixGl = config.GetEnumNamePrefixEx("GL_");
        foreach (var enumGroup in registry.EnumGroups)
        {
            foreach (var @enum in enumGroup.Items)
            {
                if (@enum.Api != null && @enum.Api != apiTarget)
                {
                    continue;
                }

                nameToEnum.Add(@enum.Name, @enum);
                globalEnums.Add(@enum);

                if (enumGroup.StartString != null && enumGroup.EndString != null)
                {
                    @enum.IsInGLEnum = true;
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

        if (apiTarget == "gl")
        {
            ExtractVersions(registry, nameToEnum, false);
            ExtractExtensions(registry, nameToEnum, false);
        }
        if (apiTarget == "gles2")
        {
            ExtractVersions(registry, nameToEnum, true);
            ExtractExtensions(registry, nameToEnum, true);
        }

        Dictionary<string, string?> groupToComment = [];
        foreach (var group in registry.EnumGroups)
        {
            if (group.Group == null) continue;
            groupToComment.Add(group.Group, config.WriteCsSummary(group.Comment));
        }

        Dictionary<string, string> nameToComment = [];
        using var fs = File.OpenRead($"{apiTarget}.json");
        nameToComment = JsonSerializer.Deserialize<Dictionary<string, string>>(fs)!;

        StringBuilder builder = new();
        foreach (var pair in groups)
        {
            string enumName = "GL" + config.GetCsCleanName(pair.Key);
            EnumPrefix prefix = config.GetEnumNamePrefixEx(pair.Key);
            Array.Resize(ref prefix.Parts, prefix.Parts.Length + 1);
            prefix.Parts[^1] = "Gl";

            groupToEnumName.Add(pair.Key, enumName);

            groupToComment.TryGetValue(pair.Key, out var comment);

            CsEnumMetadata metadata = new(pair.Key, enumName, [], comment);
            metadata.BaseType = "uint";

            if (enumName == "GLSpecialNumbers")
            {
                metadata.BaseType = "ulong";
            }

            foreach (var item in pair.Value)
            {
                string csEnumItemName = config.GetEnumName(item.Name, prefix);

                builder.AppendLine("/// <summary>");
                builder.AppendLine($"/// {nameToComment[item.Name]}");
                builder.AppendLine("/// </summary>");
                builder.Append($"/// <remarks>");
                if (item.SupportedVersionText != null)
                {
                    builder.Append(item.SupportedVersionText);
                }
                if (item.UsedByExtensionsText != null)
                {
                    if (item.SupportedVersionText != null)
                    {
                        builder.Append("<br/><br/>");
                    }
                    builder.Append(item.UsedByExtensionsText);
                }

                builder.AppendLine("</remarks>");
                string itemComment = builder.ToString();
                builder.Clear();

                item.SummaryComment = itemComment;

                CsEnumItemMetadata csEnumItem = new(item.Name, item.Value, csEnumItemName, $"unchecked(({metadata.BaseType}){item.Value})", [], itemComment);
                metadata.Items.Add(csEnumItem);
            }

            if (metadata.Items.Count == 0)
            {
                continue;
            }

            config.CustomEnums.Add(metadata);
        }

        foreach (var item in globalEnums)
        {
            if (item.IsInGLEnum && item.SummaryComment != null)
            {
                string csEnumItemNameGl = config.GetEnumName(item.Name, prefixGl);
                CsEnumItemMetadata csEnumItemGl = new(item.Name, item.Value, csEnumItemNameGl, item.Value, [], item.SummaryComment);
                glEnum.Items.Add(csEnumItemGl);
            }
        }

        return groupToEnumName;
    }

    private static void ExtractVersions(GlRegistry registry, Dictionary<string, Generator.Enum> nameToEnum, bool es)
    {
        HashSet<string> majorVersions = es ? ["GL_ES_VERSION_2", "GL_ES_VERSION_3"] : ["GL_VERSION_1", "GL_VERSION_2", "GL_VERSION_3", "GL_VERSION_4"];
        Dictionary<string, List<string>> minorVersions = [];
        Dictionary<string, List<string>> minorCoreVersions = [];
        Dictionary<string, List<string>> minorCompatVersions = [];
        for (int i = 0; i < registry.Features.Count; i++)
        {
            Feature feature = registry.Features[i];

            if (es && !feature.Name.StartsWith("GL_ES_VERSION"))
            {
                continue;
            }

            foreach (var majorVersion in majorVersions)
            {
                if (feature.Name.StartsWith(majorVersion))
                {
                    if (!minorVersions.TryGetValue(majorVersion, out var v) | !minorCoreVersions.TryGetValue(majorVersion, out var vc) | !minorCompatVersions.TryGetValue(majorVersion, out var vcomp))
                    {
                        v = [];
                        vc = [];
                        vcomp = [];
                        minorVersions.Add(majorVersion, v);
                        minorCoreVersions.Add(majorVersion, vc);
                        minorCompatVersions.Add(majorVersion, vcomp);
                    }
                    v!.Add(feature.Name);
                    if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
                    {
                        vc!.Add(feature.Name + "_CORE");
                        vcomp!.Add(feature.Name + "_COMPAT");
                    }
                }
            }

            GatherUsedTargets(registry, feature.Name, false, out var usedEnums, out _);

            if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
            {
                string featureName = $"{feature.Name}_CORE";

                foreach (var reqEnum in usedEnums)
                {
                    var @enum = nameToEnum[reqEnum];
                    @enum.SupportedVersions.Add(featureName);
                }

                string featureNameComp = $"{feature.Name}_COMPAT";
                GatherUsedTargets(registry, feature.Name, true, out var usedEnumsCompat, out _);
                foreach (var reqEnum in usedEnumsCompat)
                {
                    var @enum = nameToEnum[reqEnum];
                    if (@enum.SupportedVersions.Contains(featureName))
                    {
                        @enum.SupportedVersions.Remove(featureName);
                        @enum.SupportedVersions.Add(feature.Name);
                    }
                    else
                    {
                        @enum.SupportedVersions.Add(featureNameComp);
                    }
                }
            }
            else
            {
                foreach (var reqEnum in usedEnums)
                {
                    var @enum = nameToEnum[reqEnum];
                    @enum.SupportedVersions.Add(feature.Name);
                }
            }

            if (!es && feature.Name == "GL_VERSION_4_6")
            {
                break;
            }

            if (es && feature.Name == "GL_ES_VERSION_3_2")
            {
                break;
            }
        }

        static string GetFriendlyName(string name)
        {
            // eg transform GL_VERSION_4_6 => GL 4.6     GL_VERSION_4_6_CORE => GL 4.6 Core
            // eg transform GL_ES_VERSION_2_0 => GL ES 2.0

            ReadOnlySpan<char> span = name.AsSpan();

            if (span.StartsWith("GL_ES_VERSION_"))
            {
                span = span["GL_ES_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                return $"GL ES {major}.{minor}";
            }

            int underscores = span.Count('_');

            if (underscores == 3) // we actually only need the last digits
            {
                span = span["GL_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                return $"GL {major}.{minor}";
            }

            if (underscores == 4)
            {
                span = span["GL_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                span = span[3..];
                bool core = span.SequenceEqual("CORE");
                return $"GL {major}.{minor} {(core ? "Core" : "Compat")}";
            }

            throw new FormatException();
        }

        static void EmitRange(List<string> ranges, int start, int end, List<string> vers)
        {
            if (start == end)
            {
                ranges.Add(GetFriendlyName(vers[start]));
            }
            else
            {
                ranges.Add($"{GetFriendlyName(vers[start])} - {GetFriendlyName(vers[end])}");
            }
        }

        static void EmitFor(Generator.Enum @enum, List<string> ranges, string majorVersion, List<string> vers, bool core, bool compat)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < vers.Count; i++)
            {
                string minorVersion = vers[i];
                if (@enum.SupportedVersions.Contains(minorVersion))
                {
                    if (start == -1)
                    {
                        start = i;
                    }
                    end = i;
                }
                else if (start != -1)
                {
                    EmitRange(ranges, start, end, vers);
                    start = -1;
                }
            }

            if (start == -1)
            {
                return;
            }

            if (start == 0 && end == vers.Count - 1)
            {
                if (core)
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X_CORE"));
                }
                else if (compat)
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X_COMPAT"));
                }
                else
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X"));
                }
            }
            else
            {
                EmitRange(ranges, start, end, vers);
            }
        }

        foreach (var pair in nameToEnum)
        {
            var @enum = pair.Value;

            if (@enum.SupportedVersions.Count == 0)
                continue;

            var ranges = new List<string>();

            foreach (var majorVersion in majorVersions)
            {
                var vers = minorVersions[majorVersion];
                EmitFor(@enum, ranges, majorVersion, vers, false, false);
                if (!es && minorCoreVersions.TryGetValue(majorVersion, out var vc))
                {
                    EmitFor(@enum, ranges, majorVersion, vc, true, false);
                }
                if (!es && minorCompatVersions.TryGetValue(majorVersion, out var vcomp))
                {
                    EmitFor(@enum, ranges, majorVersion, vcomp, false, true);
                }
            }

            bool all = true;
            foreach (var range in ranges)
            {
                if (es)
                {
                    if (range != "GL ES 1.X" && range != "GL ES 2.X" && range != "GL ES 3.X")
                    {
                        all = false;
                        break;
                    }
                }
                else if (range != "GL 1.X" && range != "GL 2.X" && range != "GL 3.X" && range != "GL 4.X")
                {
                    all = false;
                    break;
                }
            }

            if (all)
            {
                @enum.SupportedVersionText = $"Supported Versions: All {(es ? "GL ES" : "GL")} versions.";
            }
            else
            {
                @enum.SupportedVersionText = $"Supported Versions:<br/>{string.Join("<br/>", ranges)}";
            }
        }
    }

    private static void ExtractExtensions(GlRegistry registry, Dictionary<string, Generator.Enum> nameToEnum, bool es)
    {
        HashSet<string> apiTargets = es ? ["gles1", "gles2"] : ["gl", "glcore"];
        HashSet<string> extensionTargets = es ? acceptedExtensionsEs : acceptedExtensions;

        foreach (var targetApi in extensionTargets)
        {
            foreach (var (_, originalName, usedEnums, _) in GatherUsedTargetsForExtension(registry, targetApi, apiTargets))
            {
                foreach (var reqEnum in usedEnums)
                {
                    var @enum = nameToEnum[reqEnum];
                    @enum.UsedByExtensions.Add(originalName);
                }
            }
        }

        foreach (var pair in nameToEnum)
        {
            var @enum = pair.Value;
            if (@enum.UsedByExtensions.Count == 0)
            {
                continue;
            }

            @enum.UsedByExtensionsText = $"Used by Extensions:<br/>{string.Join("<br/>", @enum.UsedByExtensions)}";
        }
    }

    private static void ExtractVersions(GlRegistry registry, Dictionary<string, Command> nameToCommand, bool es)
    {
        HashSet<string> majorVersions = es ? ["GL_ES_VERSION_2", "GL_ES_VERSION_3"] : ["GL_VERSION_1", "GL_VERSION_2", "GL_VERSION_3", "GL_VERSION_4"];
        Dictionary<string, List<string>> minorVersions = [];
        Dictionary<string, List<string>> minorCoreVersions = [];
        Dictionary<string, List<string>> minorCompatVersions = [];
        for (int i = 0; i < registry.Features.Count; i++)
        {
            Feature feature = registry.Features[i];

            if (es && !feature.Name.StartsWith("GL_ES_VERSION"))
            {
                continue;
            }

            foreach (var majorVersion in majorVersions)
            {
                if (feature.Name.StartsWith(majorVersion))
                {
                    if (!minorVersions.TryGetValue(majorVersion, out var v) | !minorCoreVersions.TryGetValue(majorVersion, out var vc) | !minorCompatVersions.TryGetValue(majorVersion, out var vcomp))
                    {
                        v = [];
                        vc = [];
                        vcomp = [];
                        minorVersions.Add(majorVersion, v);
                        minorCoreVersions.Add(majorVersion, vc);
                        minorCompatVersions.Add(majorVersion, vcomp);
                    }
                    v!.Add(feature.Name);
                    if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
                    {
                        vc!.Add(feature.Name + "_CORE");
                        vcomp!.Add(feature.Name + "_COMPAT");
                    }
                }
            }

            GatherUsedTargets(registry, feature.Name, false, out _, out var usedCommands);

            if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
            {
                string featureName = $"{feature.Name}_CORE";

                foreach (var reqCommand in usedCommands)
                {
                    var command = nameToCommand[reqCommand];
                    command.SupportedVersions.Add(featureName);
                }

                string featureNameComp = $"{feature.Name}_COMPAT";
                GatherUsedTargets(registry, feature.Name, true, out _, out var usedCommandsCompat);
                foreach (var reqCommand in usedCommandsCompat)
                {
                    var command = nameToCommand[reqCommand];
                    if (command.SupportedVersions.Contains(featureName))
                    {
                        command.SupportedVersions.Remove(featureName);
                        command.SupportedVersions.Add(feature.Name);
                    }
                    else
                    {
                        command.SupportedVersions.Add(featureNameComp);
                    }
                }
            }
            else
            {
                foreach (var reqCommand in usedCommands)
                {
                    var command = nameToCommand[reqCommand];
                    command.SupportedVersions.Add(feature.Name);
                }
            }

            if (!es && feature.Name == "GL_VERSION_4_6")
            {
                break;
            }

            if (es && feature.Name == "GL_ES_VERSION_3_2")
            {
                break;
            }
        }

        static string GetFriendlyName(string name)
        {
            // eg transform GL_VERSION_4_6 => GL 4.6     GL_VERSION_4_6_CORE => GL 4.6 Core
            // eg transform GL_ES_VERSION_2_0 => GL ES 2.0

            ReadOnlySpan<char> span = name.AsSpan();

            if (span.StartsWith("GL_ES_VERSION_"))
            {
                span = span["GL_ES_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                return $"GL ES {major}.{minor}";
            }

            int underscores = span.Count('_');

            if (underscores == 3) // we actually only need the last digits
            {
                span = span["GL_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                return $"GL {major}.{minor}";
            }

            if (underscores == 4)
            {
                span = span["GL_VERSION_".Length..];
                char major = span[0];
                char minor = span[2];
                span = span[3..];
                bool core = span.SequenceEqual("CORE");
                return $"GL {major}.{minor} {(core ? "Core" : "Compat")}";
            }

            throw new FormatException();
        }

        static void EmitRange(List<string> ranges, int start, int end, List<string> vers)
        {
            if (start == end)
            {
                ranges.Add(GetFriendlyName(vers[start]));
            }
            else
            {
                ranges.Add($"{GetFriendlyName(vers[start])} - {GetFriendlyName(vers[end])}");
            }
        }

        static void EmitFor(Command command, List<string> ranges, string majorVersion, List<string> vers, bool core, bool compat)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < vers.Count; i++)
            {
                string minorVersion = vers[i];
                if (command.SupportedVersions.Contains(minorVersion))
                {
                    if (start == -1)
                    {
                        start = i;
                    }
                    end = i;
                }
                else if (start != -1)
                {
                    EmitRange(ranges, start, end, vers);
                    start = -1;
                }
            }

            if (start == -1)
            {
                return;
            }

            if (start == 0 && end == vers.Count - 1)
            {
                if (core)
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X_CORE"));
                }
                else if (compat)
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X_COMPAT"));
                }
                else
                {
                    ranges.Add(GetFriendlyName($"{majorVersion}_X"));
                }
            }
            else
            {
                EmitRange(ranges, start, end, vers);
            }
        }

        foreach (var pair in nameToCommand)
        {
            var command = pair.Value;

            if (command.SupportedVersions.Count == 0)
                continue;

            var ranges = new List<string>();

            foreach (var majorVersion in majorVersions)
            {
                var vers = minorVersions[majorVersion];
                EmitFor(command, ranges, majorVersion, vers, false, false);
                if (!es && minorCoreVersions.TryGetValue(majorVersion, out var vc))
                {
                    EmitFor(command, ranges, majorVersion, vc, true, false);
                }
                if (!es && minorCompatVersions.TryGetValue(majorVersion, out var vcomp))
                {
                    EmitFor(command, ranges, majorVersion, vcomp, false, true);
                }
            }

            bool all = true;
            foreach (var range in ranges)
            {
                if (es)
                {
                    if (range != "GL ES 1.X" && range != "GL ES 2.X" && range != "GL ES 3.X")
                    {
                        all = false;
                        break;
                    }
                }
                else if (range != "GL 1.X" && range != "GL 2.X" && range != "GL 3.X" && range != "GL 4.X")
                {
                    all = false;
                    break;
                }
            }

            if (all)
            {
                command.SupportedVersionText = $"Supported Versions: All {(es ? "GL ES" : "GL")} versions.";
            }
            else
            {
                command.SupportedVersionText = $"Supported Versions:<br/>{string.Join("<br/>", ranges)}";
            }
        }
    }

    private static void ExtractExtensions(GlRegistry registry, Dictionary<string, Command> nameToCommand, bool es)
    {
        HashSet<string> apiTargets = es ? ["gles1", "gles2"] : ["gl", "glcore"];
        HashSet<string> extensionTargets = es ? acceptedExtensionsEs : acceptedExtensions;

        foreach (var targetApi in extensionTargets)
        {
            foreach (var (_, originalName, _, usedCommands) in GatherUsedTargetsForExtension(registry, targetApi, apiTargets))
            {
                foreach (var reqCommand in usedCommands)
                {
                    var command = nameToCommand[reqCommand];
                    command.UsedByExtensions.Add(originalName);
                }
            }
        }

        foreach (var pair in nameToCommand)
        {
            var command = pair.Value;
            if (command.UsedByExtensions.Count == 0)
            {
                continue;
            }

            command.UsedByExtensionsText = $"Used by Extensions:<br/>{string.Join("<br/>", command.UsedByExtensions)}";
        }
    }

    public struct Parameter : IEquatable<Parameter>
    {
        public string Name;
        public string Type;
        public bool IsOut;
        public bool IsVoid;
        public bool IsGeneric;
        public bool IsSpan;
        public bool IsRef;
        public bool IsString;
        public string? GenericType;

        public Parameter(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override readonly bool Equals(object? obj)
        {
            return obj is Parameter parameter && Equals(parameter);
        }

        public readonly bool Equals(Parameter other)
        {
            return Name == other.Name &&
                   Type == other.Type;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Name, Type);
        }

        public static bool operator ==(Parameter left, Parameter right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Parameter left, Parameter right)
        {
            return !(left == right);
        }
    }

    public class Overload : IEquatable<Overload?>
    {
        public string Name;
        public Parameter[] Parameters;
        public List<GenericParameter> Generics = [];
        public bool CallApi;
        public string Comment;

        public Overload(string name, Parameter[] parameters, string comment)
        {
            Name = name;
            Parameters = parameters;
            Comment = comment;
        }

        public Overload CreateVariation(Parameter[] parameters)
        {
            return new(Name, parameters, Comment);
        }

        public Parameter this[int index]
        {
            get => Parameters[index];
            set => Parameters[index] = value;
        }

        public bool IsSame(Overload other)
        {
            if (Name != other.Name) return false;
            bool matches = true;
            for (int i = 0; i < Parameters.Length; i++)
            {
                var p0 = Parameters[i];
                var p1 = other[i];
                if (p0.Type != p1.Type)
                {
                    matches = false;
                    break;
                }
            }

            return matches;
        }

        public override int GetHashCode()
        {
            HashCode hc = new();
            hc.Add(Name);
            for (int i = 0; i < Parameters.Length; i++)
            {
                hc.Add(Parameters[i].GetHashCode());
            }
            return hc.ToHashCode();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Overload);
        }

        public bool Equals(Overload? other)
        {
            return other is not null &&
                   Name == other.Name &&
                   EqualityComparer<Parameter[]>.Default.Equals(Parameters, other.Parameters);
        }

        public static bool operator ==(Overload? left, Overload? right)
        {
            return EqualityComparer<Overload>.Default.Equals(left, right);
        }

        public static bool operator !=(Overload? left, Overload? right)
        {
            return !(left == right);
        }
    }

    public class GenericParameter
    {
        public string Name;
        public string Constrain;

        public GenericParameter(string name, string constrain)
        {
            Name = name;
            Constrain = constrain;
        }
    }

    private static IEnumerable<string> GetReferencedCommands(GlRegistry registry, bool es)
    {
        foreach (var feature in registry.Features)
        {
            if (es && !feature.Name.StartsWith("GL_ES_VERSION"))
            {
                continue;
            }

            foreach (var req in feature.Require)
            {
                foreach (var com in req.Commands)
                {
                    yield return com.Name;
                }
            }

            if (!es && feature.Name == "GL_VERSION_4_6")
            {
                break;
            }

            if (es && feature.Name == "GL_ES_VERSION_3_2")
            {
                break;
            }
        }

        HashSet<string> apiTargets = es ? ["gles1", "gles2"] : ["gl", "glcore"];
        HashSet<string> extensionTargets = es ? acceptedExtensionsEs : acceptedExtensions;

        foreach (var targetApi in extensionTargets)
        {
            foreach (var (_, originalName, _, usedCommands) in GatherUsedTargetsForExtension(registry, targetApi, apiTargets))
            {
                foreach (var reqCommand in usedCommands)
                {
                    yield return reqCommand;
                }
            }
        }
    }

    private static void WriteFunctions(ICodeWriter writer, CsCodeGeneratorConfig config, string outputPath, GlRegistry registry, bool generateAll, HashSet<string> usedCommands, Dictionary<string, string> groupToEnumName, FunctionTableBuilder functionTableBuilder, bool es)
    {
        Dictionary<string, Command> nameToCommand = [];

        foreach (var command in registry.Commands)
        {
            nameToCommand.Add(command.Proto.Name, command);
        }

        ExtractVersions(registry, nameToCommand, es);
        ExtractExtensions(registry, nameToCommand, es);

        Dictionary<string, CommandComment?> nameToComment = [];
        FileStream fs;
        if (es)
        {
            fs = File.Create("gles2.commands.json");
        }
        else
        {
            fs = File.Create("gl.commands.json");
        }

        foreach (var command in GetReferencedCommands(registry, es))
        {
            pages.NameToComment.TryGetValue(command, out var comment);
            nameToComment.TryAdd(command, comment);
        }
        JsonSerializer.Serialize(fs, nameToComment, new JsonSerializerOptions(JsonSerializerDefaults.General) { WriteIndented = true });
        fs.Close();

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

            string returnType = ParseType(config, command.Proto);

            StringBuilder sbDefault = new();
            StringBuilder sbNameless = new();
            StringBuilder sbTypeless = new();
            StringBuilder sbTypelessApi = new();
            StringBuilder sbCompatibilityNameless = new();
            StringBuilder sbCompatibilityTypeless = new();

            List<Parameter> parameters = [];

            HashSet<string> delegateTypes = ["GLDebugProc", "GLDebugProcARB", "GLVulkanProcNV", "GLDebugProcAMD", "GLDebugProcKHR"];

            bool first = true;
            for (int i = 0; i < command.Params.Count; i++)
            {
                Param param = command.Params[i];
                var paramType = ParseType(config, param);
                var paramName = config.GetParameterName(i, param.Name);
                var paramIsBool = paramType == "byte";

                if (param.Group != null)
                {
                    paramType = groupToEnumName[param.Group];
                }

                if (config.TypeMappings.TryGetValue(paramType, out var newType))
                {
                    paramType = newType;
                }

                if (paramIsBool)
                {
                    paramType = "bool";
                }

                parameters.Add(new(paramName, paramType));

                if (!first)
                {
                    sbDefault.Append(", ");
                    sbNameless.Append(", ");
                    sbTypeless.Append(", ");
                    sbTypelessApi.Append(", ");
                    sbCompatibilityNameless.Append(", ");
                    sbCompatibilityTypeless.Append(", ");
                }
                else
                {
                    first = false;
                }

                if (delegateTypes.Contains(paramType))
                {
                    sbCompatibilityNameless.Append("nint");
                    sbCompatibilityTypeless.Append($"Utils.GetFunctionPointerForDelegate({paramName})");
                    sbDefault.Append($"{paramType} {paramName}");
                    sbNameless.Append("void*");
                    sbTypeless.Append($"(void*)Utils.GetFunctionPointerForDelegate({paramName})");
                    sbTypelessApi.Append(paramName);
                    continue;
                }

                if (paramIsBool)
                {
                    sbCompatibilityNameless.Append("byte");
                    sbCompatibilityTypeless.Append($"*((byte*)(&{paramName}))");
                    sbDefault.Append($"{paramType} {paramName}");
                    sbNameless.Append("byte");
                    sbTypeless.Append($"*((byte*)(&{paramName}))");
                    sbTypelessApi.Append(paramName);
                    continue;
                }

                if (paramType.Contains('*'))
                {
                    sbCompatibilityNameless.Append("nint");
                    sbCompatibilityTypeless.Append($"(nint){paramName}");
                }
                else
                {
                    sbCompatibilityNameless.Append(paramType);
                    sbCompatibilityTypeless.Append(paramName);
                }

                sbDefault.Append($"{paramType} {paramName}");
                sbNameless.Append(paramType);
                sbTypeless.Append(paramName);
                sbTypelessApi.Append(paramName);
            }

            bool isBool = returnType == "byte";

            int idx = functionTableBuilder.Add(command.Proto.Name);

            string returnTypeOld = returnType;
            if (returnTypeOld == "bool")
            {
                returnTypeOld = config.GetBoolType();
            }
            if (returnTypeOld.Contains('*'))
            {
                returnTypeOld = "nint";
            }

            if (first)
            {
                sbCompatibilityNameless.Append(returnTypeOld);
                sbNameless.Append(returnType);
            }
            else
            {
                sbCompatibilityNameless.Append($", {returnTypeOld}");
                sbNameless.Append($", {returnType}");
            }

            StringBuilder builder = new();

            var comment = GetCommandComment(command, nameToComment);

            builder.AppendLine("/// <summary>");

            foreach (var line in comment.Comment!.Split("\n"))
            {
                builder.AppendLine($"/// {line}");
            }
            builder.AppendLine("/// </summary>");

            /*
            foreach (var parameter in comment.Parameters)
            {
                if (parameter.Name == null)
                {
                    continue;
                }
                builder.Append($"/// <param name=\"{parameter.Name}\">");

                if (parameter.Comment == null)
                {
                    builder.AppendLine("</param>");
                    continue;
                }

                var lines = parameter.Comment.Trim().Split("\n");
                if (lines.Length == 1)
                {
                    builder.AppendLine($"{lines[0]}</param>");
                }
                else
                {
                    builder.AppendLine();
                    foreach (var line in lines)
                    {
                        builder.AppendLine($"/// {line}");
                    }
                    builder.AppendLine("/// </param>");
                }
            }*/

            builder.Append($"/// <remarks>");
            if (command.SupportedVersionText != null)
            {
                builder.Append(command.SupportedVersionText);
            }
            if (command.UsedByExtensionsText != null)
            {
                if (command.SupportedVersionText != null)
                {
                    builder.Append("<br/><br/>");
                }
                builder.Append(command.UsedByExtensionsText);
            }

            builder.AppendLine("</remarks>");
            string commandComment = builder.ToString();
            builder.Clear();

            string paramSignatureNameless = sbNameless.ToString();
            string delegateSig;
            string delegateSigCompat;
            string delegateSigApi;
            if (returnType != "void")
            {
                delegateSig = $"return ((delegate* unmanaged[Cdecl]<{paramSignatureNameless}>)funcTable[{idx}])({sbTypeless});";
                delegateSigCompat = $"return ({returnType})((delegate* unmanaged[Cdecl]<{sbCompatibilityNameless}>)funcTable[{idx}])({sbCompatibilityTypeless});";
                delegateSigApi = $"{returnType} ret = {name}Native({sbTypelessApi});";
            }
            else
            {
                delegateSig = $"((delegate* unmanaged[Cdecl]<{paramSignatureNameless}>)funcTable[{idx}])({sbTypeless});";
                delegateSigCompat = $"((delegate* unmanaged[Cdecl]<{sbCompatibilityNameless}>)funcTable[{idx}])({sbCompatibilityTypeless});";
                delegateSigApi = $"{name}Native({sbTypelessApi});";
            }

            string paramSignature = sbDefault.ToString();
            string csSig = $"internal static {returnType} {name}Native({paramSignature})";
            string csSigApi = $"{(isBool ? "bool" : returnType)} {name}({paramSignature})";

            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
            writer.BeginBlock(csSig);
            writer.WriteLine("#if NET5_0_OR_GREATER");
            writer.WriteLine(delegateSig);
            writer.WriteLine("#else");
            writer.WriteLine(delegateSigCompat);
            writer.WriteLine("#endif");

            writer.EndBlock();
            writer.WriteLine();

            writer.WriteLines(commandComment);
            writer.BeginBlock($"public static {csSigApi}");
            writer.WriteLine(delegateSigApi);
            if (returnType != "void")
            {
                if (isBool)
                {
                    writer.WriteLine("return ret != 0;");
                }
                else
                {
                    writer.WriteLine("return ret;");
                }
            }
            writer.EndBlock();
            writer.WriteLine();

            var arrayParams = parameters.ToArray();

            logger.LogInfo($"defined {csSigApi}");

            if (name.StartsWith("Gen") && parameters.Count == 2 && parameters[0].Type == "int" && parameters[1].Type == "uint*")
            {
                var newName = name[..^1];
                var signature = $"uint {newName}()";
                writer.WriteLines(commandComment);
                writer.BeginBlock($"public static {signature}");
                writer.WriteLine("uint result;");
                writer.WriteLine($"{name}Native(1, &result);");
                writer.WriteLine("return result;");
                writer.EndBlock();
                writer.WriteLine();

                logger.LogInfo($"defined {signature}");
            }

            if (name.StartsWith("Delete") && parameters.Count == 2 && parameters[0].Type == "int" && parameters[1].Type == "uint*")
            {
                var newName = name[..^1];
                var newParamName = parameters[1].Name[..^1];
                var signature = $"void {newName}(uint {newParamName})";

                writer.WriteLines(commandComment);
                writer.BeginBlock($"public static {signature}");
                writer.WriteLine($"{name}Native(1, &{newParamName});");
                writer.EndBlock();
                writer.WriteLine();

                logger.LogInfo($"defined {signature}");
            }

            if (parameters.Count > 0 && parameters[^1].Type == "int*" && (parameters[^1].Name == "@params" || parameters[^1].Name == "param"))
            {
                VariationFor(writer, commandComment, delegateSigApi, csSigApi, arrayParams, "int", parameters[^1].Name == "param");
            }
            if (parameters.Count > 0 && parameters[^1].Type == "uint*" && (parameters[^1].Name == "@params" || parameters[^1].Name == "param"))
            {
                VariationFor(writer, commandComment, delegateSigApi, csSigApi, arrayParams, "uint", parameters[^1].Name == "param");
            }
            if (parameters.Count > 0 && parameters[^1].Type == "float*" && (parameters[^1].Name == "@params" || parameters[^1].Name == "param"))
            {
                VariationFor(writer, commandComment, delegateSigApi, csSigApi, arrayParams, "float", parameters[^1].Name == "param");
            }
            if (parameters.Count > 0 && parameters[^1].Type == "ulong*" && (parameters[^1].Name == "@params" || parameters[^1].Name == "param"))
            {
                VariationFor(writer, commandComment, delegateSigApi, csSigApi, arrayParams, "ulong", parameters[^1].Name == "param");
            }
            if (parameters.Count > 0 && parameters[^1].Type == "long*" && (parameters[^1].Name == "@params" || parameters[^1].Name == "param"))
            {
                VariationFor(writer, commandComment, delegateSigApi, csSigApi, arrayParams, "long", parameters[^1].Name == "param");
            }

            // void GetShaderInfoLogNative(uint shader, int bufSize, int* length, byte* infoLog) For reference
            if (name.StartsWith("Get") &&
                parameters.Count == 4 &&
                returnType == "void" &&
                parameters[^1].Type == "byte*" &&
                parameters[^2].Name == "length" &&
                parameters[^2].Type == "int*" &&
                parameters[^3].Name == "bufSize" &&
                parameters[^3].Type == "int")
            {
                List<string> postfixes = ["Source", "InfoLog"];

                string? postfix = null;

                string? newName = null;

                foreach (var post in postfixes)
                {
                    if (name.EndsWith(post))
                    {
                        var span = name.AsSpan(3);
                        span = span[..^post.Length];
                        newName = span.ToString();
                        postfix = post;
                    }
                }

                if (postfix != null && newName != null)
                {
                    string commandTarget = $"glGet{newName}iv";
                    string? enumName = FindEnum(commandTarget, usedCommands, registry, groupToEnumName);
                    if (enumName != null)
                    {
                        string enumItem = $"{enumName}.{postfix}Length";
                        string sig = csSigApi.Replace("void", "string").Replace($", int bufSize, int* length, byte* {parameters[^1].Name}", "");
                        writer.WriteLines(commandComment);
                        writer.BeginBlock($"public static {sig}");
                        writer.WriteLine("int pStrSize0;");
                        writer.WriteLine($"Get{newName}iv({parameters[0].Name}, {enumItem}, &pStrSize0);");
                        writer.WriteLine();

                        writer.WriteLine("byte* pStr0 = null;");
                        writer.BeginBlock("if (pStrSize0 >= Utils.MaxStackallocSize)");
                        writer.WriteLine("pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);");
                        writer.EndBlock();
                        writer.BeginBlock("else");
                        writer.WriteLine("byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];");
                        writer.WriteLine("pStr0 = pStrStack0;");
                        writer.EndBlock();

                        writer.WriteLine($"{name}Native({parameters[0].Name}, pStrSize0, null, pStr0);");
                        writer.WriteLine("string ret = Utils.DecodeStringUTF8(pStr0);");

                        MarshalHelper.WriteFreeString(writer, 0);
                        writer.WriteLine("return ret;");

                        writer.EndBlock();
                        writer.WriteLine();
                    }
                }
            }

            // void ShaderSourceNative(uint shader, int count, byte** str, int* length) For reference
            if (parameters.Count == 4 &&
                returnType == "void" &&
                parameters[^1].Type == "int*" &&
                parameters[^1].Name == "length" &&
                parameters[^2].Type == "byte**" &&
                parameters[^2].Name == "str" &&
                parameters[^3].Type == "int" &&
                parameters[^3].Name == "count")
            {
                var firstParam = parameters[0];
                writer.WriteLines(commandComment);
                writer.BeginBlock($"public static void {name}({firstParam.Type} {firstParam.Name}, string source)");
                MarshalHelper.WriteStringConvertToUnmanaged(writer, StringType, "source", 0);
                writer.WriteLine($"{name}Native({firstParam.Name}, 1, &pStr0, &pStrSize0);");
                MarshalHelper.WriteFreeString(writer, 0);
                writer.EndBlock();
                writer.WriteLine();

                writer.WriteLines(commandComment);
                writer.BeginBlock($"public static void {name}({firstParam.Type} {firstParam.Name}, string[] sources)");
                WriteStringConvertToUnmanagedWithSizeArray(writer, "sources", 0);
                writer.WriteLine($"{name}Native({firstParam.Name}, sources.Length, pStrArray0, pStrArraySizes0);");
                WriteFreeUnmanagedStringArrayWithSizeArray(writer, "sources", 0);
                writer.EndBlock();
                writer.WriteLine();
            }

            if (name.EndsWith("Matrix4fv"))
            {
            }

            Overload overload = new(name, arrayParams, commandComment);

            WriteVariations(writer, returnType, overload);
        }
    }

    private static CommandComment GetCommandComment(Command command, Dictionary<string, CommandComment?> nameToComment)
    {
        if (nameToComment.TryGetValue(command.Proto.Name, out var comment) && comment != null)
        {
            return comment;
        }
        return new(command.Proto.Name, "To be documented.", []);
    }

    public static void WriteStringConvertToUnmanagedWithSizeArray(ICodeWriter writer, string name, int i)
    {
        writer.WriteLine($"byte** pStrArray{i} = null;");
        writer.WriteLine($"int* pStrArraySizes{i} = null;");
        writer.WriteLine($"int pStrArraySize{i} = Utils.GetByteCountArray({name}) + {name}.Length * sizeof(int);");
        using (writer.PushBlock($"if ({name} != null)"))
        {
            using (writer.PushBlock($"if (pStrArraySize{i} > Utils.MaxStackallocSize)"))
            {
                writer.WriteLine($"pStrArraySizes{i} = (int*)Utils.Alloc<int>({name}.Length);");
                writer.WriteLine($"pStrArray{i} = (byte**)Utils.Alloc<byte>(pStrArraySize{i});");
            }

            using (writer.PushBlock("else"))
            {
                writer.WriteLine($"byte* pStrArraySizesStack{i} = stackalloc byte[{name}.Length * sizeof(int)];");
                writer.WriteLine($"pStrArraySizes{i} = (int*)pStrArraySizesStack{i};");
                writer.WriteLine($"byte* pStrArrayStack{i} = stackalloc byte[pStrArraySize{i}];");
                writer.WriteLine($"pStrArray{i} = (byte**)pStrArrayStack{i};");
            }
        }

        using (writer.PushBlock($"for (int i = 0; i < {name}.Length; i++)"))
        {
            writer.WriteLine($"pStrArraySizes{i}[i] = Utils.GetByteCountUTF8({name}[i]);");
            writer.WriteLine($"pStrArray{i}[i] = (byte*)Utils.StringToUTF8Ptr({name}[i]);");
        }
    }

    public static void WriteFreeUnmanagedStringArrayWithSizeArray(ICodeWriter writer, string name, int i)
    {
        using (writer.PushBlock("for (int i = 0; i < " + name + ".Length; i++)"))
        {
            writer.WriteLine($"Utils.Free(pStrArray{i}[i]);");
        }

        using (writer.PushBlock($"if (pStrArraySize{i} >= Utils.MaxStackallocSize)"))
        {
            writer.WriteLine($"Utils.Free(pStrArray{i});");
            writer.WriteLine($"Utils.Free(pStrArraySizes{i});");
        }
    }

    /* For reference
        public static void ShaderSource(uint shader, string source)
        {
            byte* pStr0 = null;
            int pStrSize0 = 0;
            if (source != null)
            {
                pStrSize0 = Utils.GetByteCountUTF8(source);
                if (pStrSize0 >= Utils.MaxStackallocSize)
                {
                    pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
                }
                else
                {
                    byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
                    pStr0 = pStrStack0;
                }
                int pStrOffset0 = Utils.EncodeStringUTF8(source, pStr0, pStrSize0);
                pStr0[pStrOffset0] = 0;
            }
            ShaderSourceNative(shader, 1, &pStr0, &pStrSize0);
            if (pStrSize0 >= Utils.MaxStackallocSize)
            {
                Utils.Free(pStr0);
            }
        }
    */
    /* For reference
        public static string GetProgramInfoLog(uint program)
        {
            int len;
            GetProgramivNative(program, GLProgramPropertyARB.InfoLogLength, &len);

            byte* pStr0 = null;
            if (len >= Utils.MaxStackallocSize)
            {
                pStr0 = Utils.Alloc<byte>(len + 1);
            }
            else
            {
                byte* pStrStack0 = stackalloc byte[len + 1];
                pStr0 = pStrStack0;
            }

            GetProgramInfoLogNative(program, len, null, pStr0);
            string ret = Utils.DecodeStringUTF8(pStr0);

            if (len >= Utils.MaxStackallocSize)
            {
                Utils.Free(pStr0);
            }

            return ret;
        }
     */

    private static string? FindEnum(string commandNameTarget, HashSet<string> usedCommands, GlRegistry registry, Dictionary<string, string> groupToEnumName)
    {
        if (!usedCommands.Contains(commandNameTarget))
        {
            return null;
        }

        foreach (var command in registry.Commands)
        {
            if (command.Proto.Name == commandNameTarget)
            {
                if (command.Params.Count >= 2 && command.Params[1].PType == "GLenum")
                {
                    return groupToEnumName[command.Params[1].Group];
                }

                break;
            }
        }
        return null;
    }

    private static void VariationFor(ICodeWriter writer, string commandComment, string delegateSigApi, string csSigApi, Parameter[] arrayParams, string baseType, bool singular)
    {
        var last = arrayParams[^1];

        if (singular)
        {
            var signature = csSigApi.Replace($"{baseType}* param", $"out {baseType} param");
            var caller = delegateSigApi.Replace(last.Name, "&pparam");
            writer.WriteLines(commandComment);
            writer.BeginBlock($"public static {signature}");
            writer.WriteLine($"{baseType} pparam;");
            writer.WriteLine($"{caller}");
            writer.WriteLine("param = pparam;");
            writer.EndBlock();
            writer.WriteLine();
            logger.LogInfo($"defined {signature}");
        }
        else
        {
            var signature = csSigApi.Replace($"{baseType}* @params", $"out {baseType} @params");
            var caller = delegateSigApi.Replace(last.Name, "&pparams");
            writer.WriteLines(commandComment);
            writer.BeginBlock($"public static {signature}");
            writer.WriteLine($"{baseType} pparams;");
            writer.WriteLine($"{caller}");
            writer.WriteLine("@params = pparams;");
            writer.EndBlock();
            writer.WriteLine();
            logger.LogInfo($"defined {signature}");

            signature = csSigApi.Replace($"{baseType}* @params", $"Span<{baseType}> @params");
            caller = delegateSigApi.Replace(last.Name, "pparams");
            writer.WriteLines(commandComment);
            writer.BeginBlock($"public static {signature}");
            writer.BeginBlock($"fixed ({baseType}* pparams = @params)");
            writer.WriteLine($"{caller}");
            writer.EndBlock();
            writer.EndBlock();
            writer.WriteLine();
            logger.LogInfo($"defined {signature}");
        }

        last.IsOut = true;

        arrayParams[^1] = last;
    }

    private static void WriteFunctionTable(CsCodeGeneratorConfig config, string outputPath, FunctionTableBuilder functionTableBuilder)
    {
        var initString = functionTableBuilder.Finish(out var count);
        using var writerfuncTable = new CsCodeWriter(outputPath, config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics"], config.HeaderInjector);
        using (writerfuncTable.PushBlock($"public unsafe partial class {config.ApiName}"))
        {
            writerfuncTable.WriteLine("internal static FunctionTable funcTable;");
            writerfuncTable.WriteLine("public static INativeContext NativeContext { get; internal set; }");
            writerfuncTable.WriteLine();
            writerfuncTable.WriteLine($"public static bool Initialized => funcTable != null;");
            writerfuncTable.WriteLine();
            writerfuncTable.WriteLine("/// <summary>");
            writerfuncTable.WriteLine("/// Initializes the function table, call before you access any function.");
            writerfuncTable.WriteLine("/// </summary>");

            using (writerfuncTable.PushBlock("public static void InitApi(INativeContext context)"))
            {
                writerfuncTable.WriteLine("if (funcTable != null) return;");
                writerfuncTable.WriteLine("GLBase.NativeContext = context;");
                writerfuncTable.WriteLine($"funcTable = new FunctionTable(context, {count});");
                writerfuncTable.WriteLines(initString);
            }

            writerfuncTable.WriteLine();
            using (writerfuncTable.PushBlock("public static void FreeApi()"))
            {
                writerfuncTable.WriteLine("if (funcTable == null) return;");
                writerfuncTable.WriteLine("funcTable.Free();");
                writerfuncTable.WriteLine("funcTable = null;");
                writerfuncTable.WriteLine("GLBase.NativeContext = null;");
            }
        }
    }

    private static void WriteFunctionTableForExtension(CsCodeGeneratorConfig config, string outputPath, FunctionTableBuilder functionTableBuilder, string extensionName, string baseNamespace, string baseApi)
    {
        var initString = functionTableBuilder.Finish(out var count);
        string filePathfuncTable = outputPath;
        using var writer = new CsCodeWriter(filePathfuncTable, config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics", baseNamespace], config.HeaderInjector);
        using (writer.PushBlock($"public unsafe partial class {config.ApiName}"))
        {
            writer.WriteLine("internal static FunctionTable funcTable;");
            writer.WriteLine();
            writer.WriteLine($"public static bool Initialized => funcTable != null;");
            writer.WriteLine();
            writer.WriteLine($"public static bool IsSupported => {baseApi}.NativeContext.IsExtensionSupported(ExtensionName);");
            writer.WriteLine();
            writer.WriteLine($"public const string ExtensionName = \"{extensionName}\";");
            writer.WriteLine();

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Tries to initialize the function table of the extension, call before you access any function.");
            writer.WriteLine("/// </summary>");
            writer.WriteLine("/// <returns>Returns <c>true</c> if successful, <c>false</c> if extension is not supported.</returns>");
            using (writer.PushBlock("public static bool TryInitExtension()"))
            {
                writer.WriteLine("if (!IsSupported) return false;");
                writer.WriteLine("InitExtension();");
                writer.WriteLine("return true;");
            }
            writer.WriteLine();

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// Initializes the function table of the extension, call before you access any function.");
            writer.WriteLine("/// </summary>");
            using (writer.PushBlock("public static void InitExtension()"))
            {
                writer.WriteLine("if (funcTable != null) return;");
                writer.WriteLine($"if ({baseApi}.NativeContext == null) throw new InvalidOperationException(\"OpenGL is not initialized, call GL.InitApi.\");");
                writer.WriteLine($"funcTable = new FunctionTable({baseApi}.NativeContext, {count});");
                writer.WriteLines(initString);
            }

            writer.WriteLine();
            using (writer.PushBlock("public static void FreeExtension()"))
            {
                writer.WriteLine("if (funcTable == null) return;");
                writer.WriteLine("funcTable.Free();");
                writer.WriteLine("funcTable = null;");
            }
        }
    }
}