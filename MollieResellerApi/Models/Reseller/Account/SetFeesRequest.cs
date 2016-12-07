using MollieResellerApi.Models.Payment;

namespace MollieResellerApi.Models.Reseller.Account
{
    public class SetFeesRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentSubtype PaymentSubtype { get; set; }

        public FeeType FeeType { get; set; }

        public double Fee { get; set; }
    }
}
