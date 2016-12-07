using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class AccountValidResponse: BaseResponse
    {
        [XmlElement("exists")]
        public bool Exists { get; set; }

        [XmlElement("partner_id")]
        public long PartnerId { get; set; }
    }
}
