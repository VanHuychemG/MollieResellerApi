using System;
using MollieResellerApi.Extensions;

namespace MollieResellerApi.Models.Reseller
{
    public class BaseRequest
    {
        public string PartnerId { get; set; }

        public string ProfileKey { get; set; }

        public long Timestamp => DateTime.Now.ToUnixEpochDate();
    }
}
