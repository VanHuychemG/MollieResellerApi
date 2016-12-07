using System.Xml.Serialization;

namespace MollieResellerApi.Models.Reseller
{
    [XmlRoot("response")]
    public class BaseResponse
    {
        [XmlElement("success")]
        public bool Success { get; set; }

        [XmlElement("resultcode")]
        public int ResultCode { get; set; }

        [XmlElement("resultmessage")]
        public string ResultMessage { get; set; }
    }
}
