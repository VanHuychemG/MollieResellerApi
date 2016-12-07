using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller
{
    public class BankAccount
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("account_name")]
        public string AccountName { get; set; }

        [XmlElement("account_iban")]
        public string AccountIban { get; set; }

        [XmlElement("bic_code")]
        public string BicCode { get; set; }

        [XmlElement("bank")]
        public string Bank { get; set; }

        [XmlElement("location")]
        public string Location { get; set; }

        [XmlIgnore]
        public bool? Selected { get; set; }

        [XmlElement("selected")]
        public string SelectedAsText
        {
            get { return Selected.HasValue ? Selected.ToString() : null; }
            set { Verified = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? Verified { get; set; }

        [XmlElement("verified")]
        public string VerifiedyAsText
        {
            get { return Verified.HasValue ? Verified.ToString() : null; }
            set { Verified = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }
    }
}