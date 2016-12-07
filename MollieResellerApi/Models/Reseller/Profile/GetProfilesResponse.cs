using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Profile
{
    [XmlRoot("response")]
    public class GetProfilesResponse : BaseResponse
    {
        [XmlArray("items")]
        [XmlArrayItem("profile")]
        public WebsiteProfile[] Profiles { get; set; }
    }
}
