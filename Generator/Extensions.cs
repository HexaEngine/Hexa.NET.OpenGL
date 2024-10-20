namespace Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class GLRegistryExtensions
    {
        public static void GatherUsedTargets(this GlRegistry registry, string featureTarget, bool compatibility, out HashSet<string> usedEnums, out HashSet<string> usedCommands)
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

        public static IEnumerable<(string extensionName, string originalName, HashSet<string> usedEnums, HashSet<string> usedCommands)> GatherUsedTargetsForExtension(this GlRegistry registry, string featureTarget, HashSet<string> apiTargets)
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

        public static IEnumerable<string> GetReferencedCommands(this GlRegistry registry, bool es)
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
            HashSet<string> extensionTargets = es ? Config.AcceptedExtensionsEs : Config.AcceptedExtensions;

            foreach (var targetApi in extensionTargets)
            {
                foreach (var (_, originalName, _, usedCommands) in registry.GatherUsedTargetsForExtension(targetApi, apiTargets))
                {
                    foreach (var reqCommand in usedCommands)
                    {
                        yield return reqCommand;
                    }
                }
            }
        }

        public static void ExtractVersions(this GlRegistry registry, Dictionary<string, Generator.Enum> nameToEnum, bool es)
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

                registry.GatherUsedTargets(feature.Name, false, out var usedEnums, out _);

                if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
                {
                    string featureName = $"{feature.Name}_CORE";

                    foreach (var reqEnum in usedEnums)
                    {
                        var @enum = nameToEnum[reqEnum];
                        @enum.SupportedVersions.Add(featureName);
                    }

                    string featureNameComp = $"{feature.Name}_COMPAT";
                    registry.GatherUsedTargets(feature.Name, true, out var usedEnumsCompat, out _);
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

        public static void ExtractExtensions(this GlRegistry registry, Dictionary<string, Generator.Enum> nameToEnum, bool es)
        {
            HashSet<string> apiTargets = es ? ["gles1", "gles2"] : ["gl", "glcore"];
            HashSet<string> extensionTargets = es ? Config.AcceptedExtensionsEs : Config.AcceptedExtensions;

            foreach (var targetApi in extensionTargets)
            {
                foreach (var (_, originalName, usedEnums, _) in registry.GatherUsedTargetsForExtension(targetApi, apiTargets))
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

        public static void ExtractVersions(this GlRegistry registry, Dictionary<string, Command> nameToCommand, bool es)
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

                registry.GatherUsedTargets(feature.Name, false, out _, out var usedCommands);

                if (!es && (feature.Name.StartsWith("GL_VERSION_3") || feature.Name.StartsWith("GL_VERSION_4")))
                {
                    string featureName = $"{feature.Name}_CORE";

                    foreach (var reqCommand in usedCommands)
                    {
                        var command = nameToCommand[reqCommand];
                        command.SupportedVersions.Add(featureName);
                    }

                    string featureNameComp = $"{feature.Name}_COMPAT";
                    registry.GatherUsedTargets(feature.Name, true, out _, out var usedCommandsCompat);
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

        public static void ExtractExtensions(this GlRegistry registry, Dictionary<string, Command> nameToCommand, bool es)
        {
            HashSet<string> apiTargets = es ? ["gles1", "gles2"] : ["gl", "glcore"];
            HashSet<string> extensionTargets = es ? Config.AcceptedExtensionsEs : Config.AcceptedExtensions;

            foreach (var targetApi in extensionTargets)
            {
                foreach (var (_, originalName, _, usedCommands) in registry.GatherUsedTargetsForExtension(targetApi, apiTargets))
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
    }
}