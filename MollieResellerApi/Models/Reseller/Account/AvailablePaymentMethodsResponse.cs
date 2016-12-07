using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller.Account
{
    [XmlRoot("response")]
    public class AvailablePaymentMethodsResponse : BaseResponse
    {
        [XmlElement("services")]
        public Service Services { get; set; }
    }
}
