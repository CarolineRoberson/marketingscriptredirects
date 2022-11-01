using System.Xml.Serialization;

namespace TestRedirection;

[XmlRoot(ElementName = "rewriteMap")]
public class RewriteMap
{
    [XmlElement(ElementName = "add")] public List<Add>? Add { get; set; }

    [XmlAttribute(AttributeName = "name")] public string? Name { get; set; }

    [XmlAttribute(AttributeName = "defaultValue")]
    public string? DefaultValue { get; set; }
}