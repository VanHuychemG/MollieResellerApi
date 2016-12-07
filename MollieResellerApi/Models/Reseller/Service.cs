using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller
{
    [XmlRoot("service")]
    public class Service
    {
        [XmlIgnore]
        public bool? Ideal { get; set; }
        [XmlElement("ideal")]
        public string IdealAsText
        {
            get { return Ideal.HasValue ? Ideal.ToString() : null; }
            set { Ideal = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? CreditCard { get; set; }
        [XmlElement("creditcard")]
        public string CreditCardAsText
        {
            get { return CreditCard.HasValue ? CreditCard.ToString() : null; }
            set { CreditCard = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? MisterCash { get; set; }
        [XmlElement("mistercash")]
        public string MisterCashAsText
        {
            get { return MisterCash.HasValue ? MisterCash.ToString() : null; }
            set { MisterCash = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? Sofort { get; set; }
        [XmlElement("sofort")]
        public string SofortAsText
        {
            get { return Sofort.HasValue ? Sofort.ToString() : null; }
            set { Sofort = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? BankTransfer { get; set; }
        [XmlElement("banktransfer")]
        public string BankTransferAsText
        {
            get { return BankTransfer.HasValue ? BankTransfer.ToString() : null; }
            set { BankTransfer = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? DirectDebit { get; set; }
        [XmlElement("directdebit")]
        public string DirectDebitAsText
        {
            get { return DirectDebit.HasValue ? DirectDebit.ToString() : null; }
            set { DirectDebit = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? Belfius { get; set; }
        [XmlElement("belfius")]
        public string BelfiusAsText
        {
            get { return Belfius.HasValue ? Belfius.ToString() : null; }
            set { Belfius = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? Bitcoin { get; set; }
        [XmlElement("bitcoin")]
        public string BitcoinAsText
        {
            get { return Bitcoin.HasValue ? Bitcoin.ToString() : null; }
            set { Bitcoin = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? PodiumCadeaukaart { get; set; }
        [XmlElement("podiumcadeaukaart")]
        public string PodiumCadeaukaartAsText
        {
            get { return PodiumCadeaukaart.HasValue ? PodiumCadeaukaart.ToString() : null; }
            set { PodiumCadeaukaart = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? PayPal { get; set; }
        [XmlElement("paypal")]
        public string PayPalAsText
        {
            get { return PayPal.HasValue ? PayPal.ToString() : null; }
            set { PayPal = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? PaySafeCard { get; set; }
        [XmlElement("paysafecard")]
        public string PaySafeCardAsText
        {
            get { return PaySafeCard.HasValue ? PaySafeCard.ToString() : null; }
            set { PaySafeCard = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }

        [XmlIgnore]
        public bool? Kbc { get; set; }
        [XmlElement("kbc")]
        public string KbcAsText
        {
            get { return Kbc.HasValue ? Kbc.ToString() : null; }
            set { Kbc = !string.IsNullOrEmpty(value) ? bool.Parse(value) : default(bool?); }
        }
    }
}
