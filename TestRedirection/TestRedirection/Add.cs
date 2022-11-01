using System.Xml.Serialization;

[XmlRoot(ElementName = "add")]
public class Add
{
    [XmlAttribute(AttributeName = "key")] public string? Key { get; set; }

    [XmlAttribute(AttributeName = "value")]
    public string? Value { get; set; }
}