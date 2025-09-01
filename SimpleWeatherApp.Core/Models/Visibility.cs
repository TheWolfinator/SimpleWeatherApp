using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Visibility
{
    [XmlAttribute("value")]
    public int Value { get; set; }
}