using System.Xml.Serialization;

namespace SimpleWeatherApp.Core.Models;
public class City
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlElement("coord")]
    public Coord Coord { get; set; }

    [XmlElement("country")]
    public string Country { get; set; }

    [XmlElement("timezone")]
    public int Timezone { get; set; }

    [XmlElement("sun")]
    public Sun Sun { get; set; }
}