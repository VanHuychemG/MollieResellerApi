using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class GetLoginLinkResponse : BaseResponse
    {
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
