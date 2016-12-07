using System;

using MollieResellerApi.Extensions;

namespace MollieResellerApi.Models.Reseller
{
    public class ResellerApiException : Exception
    {
        public ResellerApiErrorMessage Details { get; set; }

        public ResellerApiException(string xmlResponse)
        {
            Details = ParseXmlResponse(xmlResponse);
        }

        private static ResellerApiErrorMessage ParseXmlResponse(string xmlResponse)
        {
            var xmlObject = xmlResponse.Deserialize<BaseResponse>();

            return new ResellerApiErrorMessage
            {
                Code = xmlObject.ResultCode,
                Message = xmlObject.ResultMessage
            };
        }

        public override string ToString()
        {
            return Details != null ? $"{Details?.Code}: {Details?.Message}" : base.ToString();
        }
    }
}
