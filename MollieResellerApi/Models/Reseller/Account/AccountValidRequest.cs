namespace MollieResellerApi.Models.Reseller.Account
{
    public class AccountValidRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
