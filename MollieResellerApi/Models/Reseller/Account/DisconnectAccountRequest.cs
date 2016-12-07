namespace MollieResellerApi.Models.Reseller.Account
{
    public class DisconnectAccountRequest: BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }
    }
}
