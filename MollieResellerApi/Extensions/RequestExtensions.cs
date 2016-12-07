using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MollieResellerApi.Extensions
{
    public static class RequestExtensions
    {
        public static IDictionary<string, string> ToDictionary<T>(this T request)
        {
            return
                request.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => Regex.Replace(prop.Name, @"(\w)([A-Z])", "$1_$2").ToLower(),
                        prop =>
                            prop.PropertyType.GetTypeInfo().IsEnum
                                ? (prop.GetValue(request, null) as Enum).StringValueOf()
                                : prop.GetValue(request, null)?.ToString());
        }

        public static string ToSortedQueryString(this IDictionary<string, string> parameters)
        {
            var sortedParameters = parameters.ToList();

            sortedParameters.Sort((x1, x2) => string.Compare(x1.Key, x2.Key, StringComparison.Ordinal));

            return string.Join("&", sortedParameters.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));
        }

        public static string StringValueOf(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
