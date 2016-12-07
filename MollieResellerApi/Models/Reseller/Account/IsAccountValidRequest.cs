namespace MollieResellerApi.Models.Reseller.Account
{
    public class IsAccountValidRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
