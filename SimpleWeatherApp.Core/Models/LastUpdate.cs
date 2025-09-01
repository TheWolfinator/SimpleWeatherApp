using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class LastUpdate
{
    [XmlAttribute("value")]
    public DateTime Value { get; set; }
}