namespace Generator
{
    using CppAst;
    using HexaGen;
    using HexaGen.Metadata;
    using HexaGen.Patching;

    internal class GlEnumPatch : PrePatch
    {
        private readonly string macroPrefix;
        private readonly string csEnumName;
        private readonly string baseType;
        private readonly HashSet<string> ignored;
        private readonly HashSet<string> extra;

        public GlEnumPatch(string macroPrefix, string csEnumName, string baseType, HashSet<string>? ignored = null, HashSet<string>? extra = null)
        {
            this.macroPrefix = macroPrefix;
            this.csEnumName = csEnumName;
            this.baseType = baseType;
            this.ignored = ignored ?? [];
            this.extra = extra ?? [];
        }

        protected override void PatchCompilation(CsCodeGeneratorConfig settings, CppCompilation compilation)
        {
            List<CppMacro> keyEnums = [];
            HashSet<string> itemNames = [];
            Dictionary<string, CsEnumItemMetadata> nameToItem = new();
            foreach (var macro in compilation.Macros)
            {
                if (ignored.Contains(macro.Name)) continue;
                if (macro.Name.StartsWith(macroPrefix) || extra.Contains(macro.Name))
                {
                    keyEnums.Add(macro);
                    itemNames.Add(macro.Name);
                    settings.IgnoredConstants.Add(macro.Name);
                }
            }

            CsEnumMetadata metadata = new(macroPrefix, csEnumName, [], null)
            {
                BaseType = baseType
            };
            var prefix = settings.GetEnumNamePrefixEx(macroPrefix);
            foreach (var macro in keyEnums)
            {
                var itemName = settings.GetEnumName(macro.Name, prefix);

                string csValue = macro.Value;
                if (csValue.IsNumeric(NumberParseOptions.All))
                {
                    // nothing to do.
                }
                else if (csValue.IsConstantExpression())
                {
                    continue;
                }
                else if (csValue.IsString())
                {
                    continue;
                }
                else if (itemNames.Contains(csValue))
                {
                    csValue = settings.GetEnumName(csValue, prefix);
                }
                else
                {
                    foreach (var item in itemNames)
                    {
                        var index = csValue.IndexOf(item);
                        if (index != -1)
                        {
                            csValue = csValue.Remove(index, item.Length);
                            csValue = csValue.Insert(index, settings.GetEnumName(item, prefix));
                        }
                    }
                }

                if (nameToItem.TryGetValue(itemName, out var csEnumItem))
                {
                    if (csEnumItem.Value == csValue)
                    {
                        continue;
                    }
                }

                CsEnumItemMetadata itemMeta = new(macro.Name, macro.Value, itemName, csValue, [], null);
                metadata.Items.Add(itemMeta);
                nameToItem.Add(itemName, itemMeta);
            }
            settings.CustomEnums.Add(metadata);
        }
    }
}