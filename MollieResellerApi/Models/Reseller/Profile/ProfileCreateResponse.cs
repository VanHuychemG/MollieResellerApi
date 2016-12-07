using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Profile
{
    [XmlRoot("response")]
    public class ProfileCreateResponse : BaseResponse
    {
        [XmlElement("profile")]
        public WebsiteProfile Profile { get; set; }
    }
}
