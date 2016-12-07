using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    public class BankAccountsResponse
    {
        [XmlArray("items")]
        [XmlArrayItem("bankaccount")]
        public BankAccount[] BankAccounts { get; set; }
    }
}
