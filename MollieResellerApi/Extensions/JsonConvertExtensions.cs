using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MollieResellerApi.Extensions
{
    public static class JsonConvertExtensions
    {
        public static string SerializeObjectCamelCase(this object value)
        {
            return JsonConvert.SerializeObject(value,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });
        }
    }
}
