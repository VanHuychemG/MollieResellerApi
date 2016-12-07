using System.ComponentModel;

namespace MollieResellerApi.Models.Payment
{
    public enum PaymentMethod
    {
        [Description("ideal")]
        Ideal,
        [Description("creditcard")]
        CreditCard,
        [Description("mistercash")]
        MisterCash,
        [Description("sofort")]
        Sofort,
        [Description("banktransfer")]
        BankTransfer,
        [Description("directdebit")]
        DirectDebit,
        [Description("belfius")]
        Belfius,
        [Description("bitcoin")]
        Bitcoin,
        [Description("podiumcadeaukaart")]
        PodiumCadeaukaart,
        [Description("paypal")]
        PayPal,
        [Description("paysafecard")]
        PaySafeCard,
        [Description("kbc")]
        Kbc
    }
}
