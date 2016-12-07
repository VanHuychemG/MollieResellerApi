using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class CreateAccountResponse: BaseResponse
    {
        [XmlElement("username")]
        public string Username { get; set; }

        [XmlElement("password")]
        public string Password { get; set; }

        [XmlElement("partner_id")]
        public long PartnerId { get; set; }
    }
}
