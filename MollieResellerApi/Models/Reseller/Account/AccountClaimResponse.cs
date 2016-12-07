using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    public class AccountClaimResponse : BaseResponse
    {
        [XmlElement("username")]
        public string Username { get; set; }

        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
