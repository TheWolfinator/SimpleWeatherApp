using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Speed
{
    [XmlAttribute("value")]
    public double Value { get; set; }

    [XmlAttribute("unit")]
    public string Unit { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }
}