using System.ComponentModel;

namespace MollieResellerApi.Models.Payment
{
    public enum PaymentSubtype
    {
        [Description("region_1")]
        Region1,
        [Description("region_2")]
        Region2,
        [Description("retail")]
        Retail,
        [Description("digital")]
        Digital,
        [Description("adult")]
        Adult,
        [Description("ideal")]
        Ideal,
        [Description("creditCard")]
        CreditCard
    }
}
