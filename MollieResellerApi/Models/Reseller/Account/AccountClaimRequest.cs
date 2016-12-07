namespace MollieResellerApi.Models.Reseller.Account
{
    public class AccountClaimRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}