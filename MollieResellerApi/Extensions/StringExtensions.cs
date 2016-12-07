using System.Security.Cryptography;
using System.Text;

namespace MollieResellerApi.Extensions
{
    public static class StringExtensions
    {
        public static string Hash(this string s, string secret)
        {
            var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(secret));

            var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(s));

            return HexStringFromBytes(hashBytes);
        }

        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
}
