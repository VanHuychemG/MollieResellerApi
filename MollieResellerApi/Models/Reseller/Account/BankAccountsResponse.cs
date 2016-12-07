using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class BankAccountsResponse : BaseResponse
    {
        [XmlArray("items")]
        [XmlArrayItem("bankaccount")]
        public BankAccount[] BankAccounts { get; set; }
    }
}
