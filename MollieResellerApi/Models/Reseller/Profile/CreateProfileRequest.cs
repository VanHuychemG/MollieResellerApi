namespace MollieResellerApi.Models.Reseller.Profile
{
    public class CreateProfileRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }

        public string Name { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Category Category { get; set; }
    }
}
