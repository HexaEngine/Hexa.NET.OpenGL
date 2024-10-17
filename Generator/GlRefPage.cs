namespace Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    public class GlRefPages
    {
        public List<GlFunctionRef> Functions = [];

        public void Parse(string folder)
        {
            foreach (string file in Directory.GetFiles(folder, "*.xml"))
            {
                ParseRefPage(file);
            }
        }

        private static XNamespace ns = "http://docbook.org/ns/docbook";

        /// <summary>
        ///
        /// </summary>
        /// <param name="file"></param>
        private void ParseRefPage(string file)
        {
            XDocument doc;
            try
            {
                doc = XDocument.Load(file);
            }
            catch
            {
                return;
            }

            var functionName = doc.Descendants(ns + "refname").FirstOrDefault()?.Value;
            var functionPurpose = doc.Descendants(ns + "refpurpose").FirstOrDefault()?.Value;
            var description = doc.Descendants(ns + "refsect1").FirstOrDefault(x => (string?)x.Attribute(XNamespace.Xml + "id") == "description");
            var parameters = doc.Descendants(ns + "refsect1").FirstOrDefault(x => (string?)x.Attribute(XNamespace.Xml + "id") == "parameters")?.Descendants(ns + "variablelist")?.FirstOrDefault();

            string? x = ConvertToXmlComment(functionPurpose, description);

            var parsedParameters = ReadParameters(parameters);

            StringBuilder summaryBuilder = new();
            if (x != null)
            {
                summaryBuilder.AppendLine("/// <summary>");
                foreach (var line in x.Trim().Split(Environment.NewLine))
                {
                    summaryBuilder.AppendLine($"/// {line}");
                }
                foreach (var parameter in parsedParameters)
                {
                    summaryBuilder.Append("/// <param name=\"{parameter.Name}\">");
                    var lines = parameter.Comment.Trim().Split(Environment.NewLine);
                    if (lines.Length == 1)
                    {
                        summaryBuilder.AppendLine($"{lines[0]}</param>");
                    }
                    else
                    {
                        summaryBuilder.AppendLine();
                        foreach (var line in lines)
                        {
                            summaryBuilder.AppendLine("/// {line}");
                        }
                        summaryBuilder.AppendLine("</param>");
                    }
                }
            }

            Console.WriteLine($"Function Name: {functionName}");
            Console.WriteLine($"Purpose: {functionPurpose}");
            Console.WriteLine($"Description: {summaryBuilder}");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="functionPurpose"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        private static List<Parameter> ReadParameters(XElement? parameters)
        {
            List<Parameter> parsedParameters = [];
            if (parameters == null) return parsedParameters;
            var reader = parameters.CreateReader();

            while (reader.Read())
            {
                Parameter parameter = new();
                if (reader.IsStartElement("varlistentry"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement("term"))
                        {
                            reader.ReadStartElement();
                            if (reader.IsStartElement("parameter"))
                            {
                                reader.ReadStartElement();
                                parameter.Name = reader.ReadContentAsString();
                            }
                        }

                        if (reader.IsStartElement("listitem"))
                        {
                            reader.ReadStartElement();
                            if (reader.IsStartElement("para"))
                            {
                                reader.ReadStartElement();
                                StringBuilder sb = new();
                                ReadComment(sb, reader);
                                parameter.Comment = sb.ToString();
                            }
                        }

                        if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "varlistentry")
                        {
                            break;
                        }
                    }
                }
                parsedParameters.Add(parameter);

                if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "variablelist")
                {
                    break;
                }
            }

            return parsedParameters;
        }

        private static string? ConvertToXmlComment(string? functionPurpose, XElement? description)
        {
            if (description == null) return functionPurpose;

            StringBuilder sb = new(functionPurpose);

            bool first = functionPurpose == null;
            foreach (var entry in description.Descendants(ns + "para"))
            {
                if (!first)
                {
                    sb.AppendLine();
                }
                else
                {
                    first = false;
                }
                var reader = entry.CreateReader();
                ReadComment(sb, reader);
            }

            return sb.ToString();
        }

        private static void ReadComment(StringBuilder sb, XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement("function"))
                {
                    reader.ReadStartElement();
                    var func = reader.ReadContentAsString().AsSpan();
                    if (func.StartsWith("gl_", StringComparison.OrdinalIgnoreCase))
                    {
                        func = func[3..];
                    }
                    if (func.StartsWith("gl", StringComparison.OrdinalIgnoreCase))
                    {
                        func = func[2..];
                    }
                    sb.Append($"<see cref=\"{func}\"/>");
                    reader.ReadEndElement();
                }

                if (reader.IsStartElement("parameter"))
                {
                    reader.ReadStartElement();
                    var param = reader.ReadContentAsString();
                    sb.Append($"<paramref name=\"{param}\"/>");
                    reader.ReadEndElement();
                }

                if (reader.IsStartElement("emphasis"))
                {
                    reader.ReadStartElement();
                    var text = reader.ReadContentAsString();
                    sb.Append($"<c>{text}</c>");
                }

                if (reader.NodeType == XmlNodeType.Text)
                {
                    sb.Append(reader.Value);
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.LocalName == "para")
                {
                    break;
                }
            }
        }
    }

    public class GlFunctionRef
    {
    }

    public struct Parameter
    {
        public string Name { get; set; }

        public string Comment { get; set; }
    }
}