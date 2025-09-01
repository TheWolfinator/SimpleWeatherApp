using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Pressure
{
    [XmlAttribute("value")]
    public int Value { get; set; }

    [XmlAttribute("unit")]
    public string Unit { get; set; }
}