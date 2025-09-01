using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class Sun
{
    [XmlAttribute("rise")]
    public DateTime Rise { get; set; }

    [XmlAttribute("set")]
    public DateTime Set { get; set; }
}