using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class BankAccountEditResponse : BaseResponse
    {
        [XmlElement("bankaccount")]
        public BankAccount BankAccount { get; set; }
    }
}
