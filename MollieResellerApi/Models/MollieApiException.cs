using System;

using Newtonsoft.Json;

namespace MollieResellerApi.Models
{
    public class MollieApiException : Exception
    {
        public MollieErrorMessage Details { get; set; }

        public MollieApiException(string json) : base(CreateExceptionMessage(ParseErrorJsonResponse(json)))
        {
            Details = ParseErrorJsonResponse(json);
        }

        private static string CreateExceptionMessage(MollieErrorMessage error)
        {
            return !string.IsNullOrEmpty(error.Field) ? $"Error occured in field: {error.Field} - {error.Message}" : error.Message;
        }

        private static MollieErrorMessage ParseErrorJsonResponse(string json)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(json);

            return new MollieErrorMessage
            {
                Message = jsonObject.error.message,
                Field = jsonObject.error.field,
                Type = jsonObject.error.type,
            };
        }

        public override string ToString()
        {
            return Details != null ? $"{Details?.Message}" : base.ToString();
        }
    }
}
