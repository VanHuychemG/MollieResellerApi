namespace MollieResellerApi.Models.Reseller.Profile
{
    public class GetProfilesRequest :BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }
    }
}
