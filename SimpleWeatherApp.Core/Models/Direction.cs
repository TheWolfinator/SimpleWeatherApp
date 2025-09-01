using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Direction
{
    [XmlAttribute("value")]
    public int Value { get; set; }

    [XmlAttribute("code")]
    public string Code { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }
}