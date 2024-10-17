namespace Generator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [XmlRoot("registry")]
    public class GlRegistry
    {
        [XmlArray("commands")]
        [XmlArrayItem("command")]
        public List<Command> Commands { get; set; } = new List<Command>();

        [XmlArray("types")]
        [XmlArrayItem("type")]
        public List<Type> Types { get; set; } = new List<Type>();

        [XmlElement("enums")]
        public List<Enums> EnumGroups { get; set; } = new List<Enums>();

        [XmlElement("feature")]
        public List<Feature> Features { get; set; } = new List<Feature>();

        [XmlElement("extensions")]
        public Extensions Extensions { get; set; } = new();
    }

    [XmlRoot(ElementName = "command")]
    public class Command
    {
        [XmlElement(ElementName = "proto")]
        public Proto Proto { get; set; }

        [XmlElement(ElementName = "param")]
        public List<Param> Params { get; set; }

        [XmlElement(ElementName = "alias")]
        public Alias Alias { get; set; }
    }

    [XmlRoot(ElementName = "alias")]
    public class Alias
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "proto")]
    public class Proto : IXmlSerializable, IGlType
    {
        public string Kind { get; set; }
        public string Prefix { get; set; }
        public string PType { get; set; }
        public string Postfix { get; set; }
        public string Name { get; set; }

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Kind = reader.GetAttribute("kind");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (PType == null)
                    {
                        Prefix = reader.Value.Trim();
                    }
                    else
                    {
                        Postfix = reader.Value.Trim();
                    }
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ptype")
                {
                    reader.ReadStartElement();
                    PType = reader.ReadContentAsString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                {
                    reader.ReadStartElement();
                    Name = reader.ReadContentAsString();
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "proto")
                {
                    break;
                }
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            // not important for us.
            throw new NotSupportedException("");
        }
    }

    [XmlRoot(ElementName = "param")]
    public class Param : IXmlSerializable, IGlType
    {
        public string Group { get; set; }

        public string Kind { get; set; }

        public string Len { get; set; }

        public string PType { get; set; }

        public string Name { get; set; }

        public string Prefix { get; set; }

        public string Postfix { get; set; }

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Group = reader.GetAttribute("group")!;
            Kind = reader.GetAttribute("kind")!;
            Len = reader.GetAttribute("len")!;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    if (PType == null)
                    {
                        Prefix = reader.Value.Trim();
                    }
                    else
                    {
                        Postfix = reader.Value.Trim();
                    }
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ptype")
                {
                    reader.ReadStartElement();
                    PType = reader.ReadContentAsString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                {
                    reader.ReadStartElement();
                    Name = reader.ReadContentAsString();
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "param")
                {
                    break;
                }
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            // not important for us.
            throw new NotSupportedException("");
        }
    }

    [XmlRoot(ElementName = "type")]
    public class Type
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string Comment { get; set; }

        [XmlAttribute(AttributeName = "requires")]
        public string Requires { get; set; }

        [XmlElement(ElementName = "apientry")]
        public object Apientry { get; set; }
    }

    [XmlRoot(ElementName = "unused")]
    public class Unused
    {
        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }

        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string Comment { get; set; }
    }

    [XmlRoot(ElementName = "enums")]
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Enums
    {
        private string? startString;
        private string? endString;

        [XmlElement(ElementName = "enum")]
        public List<Enum> Items { get; set; }

        [XmlElement(ElementName = "unused")]
        public Unused Unused { get; set; }

        [XmlAttribute(AttributeName = "namespace")]
        public string Namespace { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string? Comment { get; set; }

        [XmlAttribute(AttributeName = "start")]
        public string? StartString
        {
            get => startString;
            set
            {
                startString = value;
                if (value != null)
                {
                    Start = uint.Parse(value.AsSpan(2), NumberStyles.HexNumber);
                }
            }
        }

        [XmlAttribute(AttributeName = "end")]
        public string? EndString
        {
            get => endString;
            set
            {
                endString = value;
                if (value != null)
                {
                    End = uint.Parse(value.AsSpan(2), NumberStyles.HexNumber);
                }
            }
        }

        [XmlIgnore]
        public uint Start { get; set; }

        [XmlIgnore]
        public uint End { get; set; }

        [XmlAttribute(AttributeName = "group")]
        public string Group { get; set; }

        [XmlAttribute(AttributeName = "vendor")]
        public string Vendor { get; set; }

        private string GetDebuggerDisplay()
        {
            return Group;
        }
    }

    [XmlRoot(ElementName = "enum")]
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Enum
    {
        private string group;

        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "api")]
        public string Api { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string? Comment { get; set; }

        [XmlAttribute(AttributeName = "group")]
        public string Group
        {
            get => group;
            set
            {
                group = value;
                if (value != null)
                {
                    GroupList.Clear();
                    GroupList.AddRange(value.Split(',').Select(g => g.Trim()));
                }
            }
        }

        [XmlIgnore]
        public List<string> GroupList { get; } = [];

        private string GetDebuggerDisplay()
        {
            return $"{Name} = {Value}; Groups=[{Group}]";
        }
    }

    [XmlRoot(ElementName = "enum")]
    public class FeatureEnum
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [XmlRoot(ElementName = "require")]
    public class Require
    {
        [XmlElement(ElementName = "enum")]
        public List<FeatureEnum> Enums { get; set; }

        [XmlElement(ElementName = "command")]
        public List<FeatureCommand> Commands { get; set; }

        [XmlAttribute(AttributeName = "profile")]
        public string Profile { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string Comment { get; set; }

        public override string ToString()
        {
            return Comment;
        }
    }

    [XmlRoot(ElementName = "command")]
    public class FeatureCommand
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [XmlRoot(ElementName = "feature")]
    public class Feature
    {
        [XmlElement(ElementName = "require")]
        public List<Require> Require { get; set; }

        [XmlElement(ElementName = "remove")]
        public List<Remove> Remove { get; set; }

        [XmlAttribute(AttributeName = "api")]
        public string Api { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [XmlRoot(ElementName = "extension")]
    public class Extension
    {
        private string? supported;

        [XmlElement(ElementName = "require")]
        public List<Require> Require { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "supported")]
        public string? Supported
        {
            get => supported;
            set
            {
                supported = value;
                SupportedList.Clear();
                if (value != null)
                {
                    SupportedList.AddRange(value.Split('|'));
                }
            }
        }

        [XmlIgnore]
        public List<string> SupportedList { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }
    }

    [XmlRoot(ElementName = "extensions")]
    public class Extensions
    {
        [XmlElement(ElementName = "extension")]
        public List<Extension> Extension { get; set; }
    }

    [XmlRoot(ElementName = "remove")]
    public class Remove
    {
        [XmlElement(ElementName = "enum")]
        public List<FeatureEnum> Enums { get; set; }

        [XmlElement(ElementName = "command")]
        public List<FeatureCommand> Commands { get; set; }

        [XmlAttribute(AttributeName = "profile")]
        public string Profile { get; set; }

        [XmlAttribute(AttributeName = "comment")]
        public string Comment { get; set; }
    }
}