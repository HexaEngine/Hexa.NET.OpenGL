﻿using Generator;
using HexaGen;
using HexaGen.Core;
using HexaGen.Core.CSharp;
using HexaGen.Metadata;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

internal class Program
{
    private static readonly LoggerBase logger = new();
    private static readonly ConfigComposer composer = new();

    private static void Main(string[] args)
    {
        XmlSerializer serializer = new(typeof(GlRegistry));
        using var fs = File.OpenRead("gl.xml");
        GlRegistry registry = (GlRegistry)serializer.Deserialize(fs)!;

        Dictionary<string, HashSet<string>> extensions = new();

        foreach (var ex in registry.Extensions.Extension)
        {
            var span = ex.Name.AsSpan();

            if (span.StartsWith("GL_"))
            {
                span = span[3..];
            }

            int idx = span.IndexOf('_');
            if (idx != -1)
            {
                var name = span[..idx].ToString();
                if (!extensions.TryGetValue(name, out var extension))
                {
                    extension = new();
                    extensions.Add(name, extension);
                }
                extension.AddRange(ex.SupportedList);
            }
        }

        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.base.json");

        var groupToEnumName = GenerateEnums(config, registry, "gl");
        {
            CsCodeGenerator generator = new(config);
            generator.LogToConsole();
            generator.Generate("include/main.h", "../../../../Hexa.NET.OpenGL.Base/Generated");
        }

        config = CsCodeGeneratorConfig.Load("es/generator.base.json");

        var groupToEnumNameEs = GenerateEnums(config, registry, "gles");
        {
            CsCodeGenerator generator = new(config);
            generator.LogToConsole();
            generator.Generate("include/main.h", "../../../../Hexa.NET.OpenGLES.Base/Generated");
        }

        logger.LogToConsole();

        Generate(registry, "generator.json", "GL_VERSION_2_1", compatibility: false, false, "../../../../Hexa.NET.OpenGL2/Generated", groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_3_3", compatibility: false, false, "../../../../Hexa.NET.OpenGL3/Generated", groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_4_6", compatibility: false, false, "../../../../Hexa.NET.OpenGL4/Generated", groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_3_3", compatibility: true, false, "../../../../Hexa.NET.OpenGL3.Compat/Generated", groupToEnumName);
        Generate(registry, "generator.json", "GL_VERSION_4_6", compatibility: true, false, "../../../../Hexa.NET.OpenGL4.Compat/Generated", groupToEnumName);
        Generate(registry, "es/generator.json", "GL_ES_VERSION_2_0", compatibility: false, false, "../../../../Hexa.NET.OpenGLES2/Generated", groupToEnumNameEs);
        Generate(registry, "es/generator.json", "GL_ES_VERSION_3_2", compatibility: false, false, "../../../../Hexa.NET.OpenGLES3/Generated", groupToEnumNameEs);
        GenerateExtension(registry, "generator.ext.json", "GL_EXT", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.EXT/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.arb.json", "GL_ARB", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.ARB/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.nv.json", "GL_NV", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.NV/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.amd.json", "GL_AMD", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.AMD/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.apple.json", "GL_APPLE", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.APPLE/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.intel.json", "GL_INTEL", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.INTEL/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.khr.json", "GL_KHR", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.KHR/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.mesa.json", "GL_MESA", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.MESA/Generated", groupToEnumName);
        GenerateExtension(registry, "generator.ovr.json", "GL_OVR", ["gl", "glcore"], "../../../../Hexa.NET.OpenGL.OVR/Generated", groupToEnumName);

        GenerateExtension(registry, "es/generator.android.json", "GL_ANDROID", ["gles2"], "../../../../Hexa.NET.OpenGLES.ANDROID/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.ext.json", "GL_EXT", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.EXT/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.amd.json", "GL_AMD", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.AMD/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.angle.json", "GL_ANGLE", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.ANGLE/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.arm.json", "GL_ARM", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.ARM/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.intel.json", "GL_INTEL", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.INTEL/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.khr.json", "GL_KHR", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.KHR/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.mesa.json", "GL_MESA", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.MESA/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.nv.json", "GL_NV", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.NV/Generated", groupToEnumNameEs, true);
        GenerateExtension(registry, "es/generator.oes.json", "GL_OES", ["gles1", "gles2"], "../../../../Hexa.NET.OpenGLES.OES/Generated", groupToEnumNameEs, true);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("All Done!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void Generate(GlRegistry registry, string configPath, string featureTarget, bool compatibility, bool generateAll, string outputPath, Dictionary<string, string> groupToEnumName)
    {
        string functionsOutputPath = Path.Combine(outputPath, "Functions");

        if (Directory.Exists(functionsOutputPath))
        {
            Directory.Delete(functionsOutputPath, true);
        }
        Directory.CreateDirectory(functionsOutputPath);

        logger.LogInfo($"Generating {featureTarget} ...");
        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load(configPath);

        composer.Compose(config);

        GatherUsedTargets(registry, featureTarget, compatibility, out _, out HashSet<string> usedCommands);
        FunctionTableBuilder functionTableBuilder = new();
        using CsSplitCodeWriter writer = new(Path.Combine(functionsOutputPath, "Functions.cs"), config.Namespace, ["System", "HexaGen.Runtime", "System.Runtime.CompilerServices", "System.Numerics"], null);

        writer.BeginBlock($"public static unsafe partial class {config.ApiName}");
        WriteFunctions(writer, config, outputPath, registry, generateAll, usedCommands, groupToEnumName, functionTableBuilder);
        writer.EndBlock();

        WriteFunctionTable(config, Path.Combine(outputPath, "FunctionTable.cs"), functionTableBuilder);
        logger.LogInfo($"Done Generating {featureTarget} ...");
    }

    private static void GenerateExtension(GlRegistry registry, string configPath, string extensionTarget, HashSet<string> apiTargets, string outputPath, Dictionary<string, string> groupToEnumName, bool es = false)
    {
        string functionsOutputPath = Path.Combine(outputPath, "Functions");

        if (Directory.Exists(functionsOutputPath))
        {
            Directory.Delete(functionsOutputPath, true);
        }
        Directory.CreateDirectory(functionsOutputPath);

        logger.LogInfo($"Generating {extensionTarget} ...");
        CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load(configPath);

        composer.Compose(config);

        foreach (var (extensionName, _, usedCommands) in GatherUsedTargetsForExtension(registry, extensionTarget, apiTargets))
        {
            WriteExtension(registry, outputPath, groupToEnumName, es, functionsOutputPath, config, extensionName, usedCommands);
        }

        logger.LogInfo($"Done Generating {extensionTarget} ...");
    }

    private static void WriteExtension(GlRegistry registry, string outputPath, Dictionary<string, string> groupToEnumName, bool es, string functionsOutputPath, CsCodeGeneratorConfig config, string extensionName, HashSet<string> usedCommands)
    {
        if (usedCommands.Count == 0) return;
        logger.LogInfo($"Generating {extensionName} ...");
        config.ApiName = extensionName;
        FunctionTableBuilder functionTableBuilder = new();
        using CsSplitCodeWriter writer = new(Path.Combine(functionsOutputPath, $"{extensionName}.cs"), config.Namespace, ["System", "HexaGen.Runtime", "System.Runtime.CompilerServices", "System.Numerics"], null);

        writer.BeginBlock($"public static unsafe partial class {config.ApiName}");
        WriteFunctions(writer, config, outputPath, registry, false, usedCommands, groupToEnumName, functionTableBuilder);
        writer.EndBlock();

        WriteFunctionTableForExtension(config, Path.Combine(functionsOutputPath, $"{extensionName}.FN.cs"), functionTableBuilder, es ? "Hexa.NET.OpenGLES" : "Hexa.NET.OpenGL", "GLBase");
        logger.LogInfo($"Done Generating {extensionName} ...");
    }

    private static void WriteVariations(ICodeWriter writer, string returnType, string name, (string type, string name)[] parameters)
    {
        long maxVariations = (long)Math.Pow(2L, parameters.Length);
        List<(string type, string name)[]> defs = [parameters];
        for (long ix = 1; ix < maxVariations; ix++)
        {
            (string type, string name)[] stringVariation = new (string type, string name)[parameters.Length];
            (string type, string name)[] spanVariation = new (string type, string name)[parameters.Length];
            (string type, string name)[] refVariation = new (string type, string name)[parameters.Length];

            for (int j = 0; j < parameters.Length; j++)
            {
                var bit = (ix & 1 << j - 64) != 0;

                (string type, string name) parameter = parameters[j];

                if (bit)
                {
                    if (parameter.type == "byte*")
                    {
                        stringVariation[j] = ("string", parameter.name);
                        spanVariation[j] = ("ReadOnlySpan<byte>", parameter.name);
                    }
                    else
                    {
                        spanVariation[j] = stringVariation[j] = parameter;
                    }

                    var pointerDepth = parameter.type.AsSpan().Count('*');
                    if (pointerDepth == 1 && parameter.type != "void*")
                    {
                        var cleanName = parameter.type.Replace("*", string.Empty);
                        refVariation[j] = ($"ref {cleanName}", parameter.name);
                    }
                    else
                    {
                        refVariation[j] = parameter;
                    }
                }
                else
                {
                    refVariation[j] = spanVariation[j] = stringVariation[j] = parameter;
                }
            }

            WriteFunction(returnType, name, parameters, writer, defs, stringVariation);
            WriteFunction(returnType, name, parameters, writer, defs, spanVariation);
            WriteFunction(returnType, name, parameters, writer, defs, refVariation);
        }
    }

    private static void WriteFunction(string returnType, string name, (string type, string name)[] rootParameters, ICodeWriter writer, List<(string type, string name)[]> defs, (string type, string name)[] variation)
    {
        bool found = false;

        foreach (var def in defs)
        {
            bool matches = true;
            for (int i = 0; i < def.Length; i++)
            {
                var p0 = def[i];
                var p1 = variation[i];
                if (p0.type != p1.type)
                {
                    matches = false;
                    break;
                }
            }

            if (matches)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            return;
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
        for (int i = 0; i < variation.Length; i++)
        {
            (string paramType, string paramName) = variation[i];

            string paramListName = paramName;

            if (paramType == "string")
            {
                stringStack.Add((paramName, stringIdx));
                paramListName = $"pStr{stringIdx}";
                stringIdx++;
            }

            if (paramType == "ReadOnlySpan<byte>" || paramType.StartsWith("ref"))
            {
                paramListName = $"p{paramName.Replace("@", string.Empty)}{fixedStack.Count}";
                fixedStack.Add((paramName, paramListName, rootParameters[i].type, i));
            }

            if (first)
            {
                sb.Append($"{paramType} {paramName}");
                sbNameless.Append(paramType);
                sbParam.Append(paramListName);
                first = false;
            }
            else
            {
                sb.Append($", {paramType} {paramName}");
                sbNameless.Append($", {paramType}");
                sbParam.Append($", {paramListName}");
            }
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

        string functionSignatureApi = $"{(isBool ? "bool" : returnType)} {name}({sb})";
        logger.LogInfo($"defined {functionSignatureApi}");

        string functionHeader = $"public static {functionSignatureApi}";

        writer.BeginBlock(functionHeader);

        foreach (var str in stringStack)
        {
            MarshalHelper.WriteStringConvertToUnmanaged(writer, new CsType("byte*", CsPrimitiveType.Byte) { StringType = CsStringType.StringUTF8 }, str.name, str.index);
        }

        foreach (var fx in fixedStack)
        {
            if (variation[fx.index].type.Contains("ref"))
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

    private static IEnumerable<(string extensionName, HashSet<string> usedEnums, HashSet<string> usedCommands)> GatherUsedTargetsForExtension(GlRegistry registry, string featureTarget, HashSet<string> apiTargets)
    {
        HashSet<string> androidTarget = [
            "KHR_debug",
            "KHR_texture_compression_astc_ldr",
            "KHR_blend_equation_advanced",
            "OES_sample_shading",
            "OES_sample_variables",
            "OES_shader_image_atomic",
            "OES_shader_multisample_interpolation",
            "OES_texture_stencil8",
            "OES_texture_storage_multisample_2d_array",
            "EXT_copy_image",
            "EXT_draw_buffers_indexed",
            "EXT_geometry_shader",
            "EXT_gpu_shader5",
            "EXT_primitive_bounding_box",
            "EXT_shader_io_blocks",
            "EXT_tessellation_shader",
            "EXT_texture_border_clamp",
            "EXT_texture_buffer",
            "EXT_texture_cube_map_array",
            "EXT_texture_srgb_decode",
            ];
        HashSet<string> usedEnums = [];
        HashSet<string> usedCommands = [];
        foreach (var extension in registry.Extensions.Extension)
        {
            usedEnums.Clear();
            usedCommands.Clear();

            if (featureTarget == "GL_ANDROID")
            {
                if (!androidTarget.Contains(extension.Name[3..]))
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

            yield return (nameFormatted, usedEnums, usedCommands);
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

        return groupToEnumName;
    }

    private static void WriteFunctions(ICodeWriter writer, CsCodeGeneratorConfig config, string outputPath, GlRegistry registry, bool generateAll, HashSet<string> usedCommands, Dictionary<string, string> groupToEnumName, FunctionTableBuilder functionTableBuilder)
    {
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

            List<(string type, string name)> parameters = [];

            HashSet<string> delegateTypes = ["GLDebugProc", "GLDebugProcARB", "GLVulkanProcNV", "GLDebugProcAMD", "GLDebugProcKHR"];

            bool first = true;
            for (int i = 0; i < command.Params.Count; i++)
            {
                Param param = command.Params[i];
                var paramType = ParseType(config, param);
                var paramName = config.GetParameterName(i, param.Name);

                if (param.Group != null)
                {
                    paramType = groupToEnumName[param.Group];
                }

                if (config.TypeMappings.TryGetValue(paramType, out var newType))
                {
                    paramType = newType;
                }

                parameters.Add((paramType, paramName));

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

            WriteVariations(writer, returnType, name, arrayParams);
        }
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

    private static void WriteFunctionTableForExtension(CsCodeGeneratorConfig config, string outputPath, FunctionTableBuilder functionTableBuilder, string baseNamespace, string baseApi)
    {
        var initString = functionTableBuilder.Finish(out var count);
        string filePathfuncTable = outputPath;
        using var writerfuncTable = new CsCodeWriter(filePathfuncTable, config.Namespace, ["System", "HexaGen.Runtime", "System.Numerics", baseNamespace], config.HeaderInjector);
        using (writerfuncTable.PushBlock($"public unsafe partial class {config.ApiName}"))
        {
            writerfuncTable.WriteLine("internal static FunctionTable funcTable;");
            writerfuncTable.WriteLine();
            writerfuncTable.WriteLine($"public static bool Initialized => funcTable != null;");
            writerfuncTable.WriteLine();
            writerfuncTable.WriteLine("/// <summary>");
            writerfuncTable.WriteLine("/// Initializes the function table of the extension, call before you access any function.");
            writerfuncTable.WriteLine("/// </summary>");

            using (writerfuncTable.PushBlock("public static void InitExtension()"))
            {
                writerfuncTable.WriteLine("if (funcTable != null) return;");
                writerfuncTable.WriteLine($"if ({baseApi}.NativeContext == null) throw new InvalidOperationException(\"OpenGL is not initialized, call GL.InitApi.\");");
                writerfuncTable.WriteLine($"funcTable = new FunctionTable({baseApi}.NativeContext, {count});");
                writerfuncTable.WriteLines(initString);
            }

            writerfuncTable.WriteLine();
            using (writerfuncTable.PushBlock("public static void FreeExtension()"))
            {
                writerfuncTable.WriteLine("if (funcTable == null) return;");
                writerfuncTable.WriteLine("funcTable.Free();");
                writerfuncTable.WriteLine("funcTable = null;");
            }
        }
    }
}