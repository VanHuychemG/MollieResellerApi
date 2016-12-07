using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller
{
    [XmlRoot("api_keys")]
    public class ApiKeys
    {
        [XmlElement("test")]
        public string TestKey { get; set; }

        [XmlElement("live")]
        public string LiveKey { get; set; }
    }
}
