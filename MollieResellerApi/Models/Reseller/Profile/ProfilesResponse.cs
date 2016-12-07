using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Profile
{
    [XmlRoot("response")]
    public class ProfilesResponse : BaseResponse
    {
        [XmlArray("items")]
        [XmlArrayItem("profile")]
        public WebsiteProfile[] Profiles { get; set; }
    }
}
