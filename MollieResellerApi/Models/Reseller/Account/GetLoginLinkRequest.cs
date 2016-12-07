namespace MollieResellerApi.Models.Reseller.Account
{
    public class GetLoginLinkRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }

        public string RedirectUrl { get; set; }
    }
}
