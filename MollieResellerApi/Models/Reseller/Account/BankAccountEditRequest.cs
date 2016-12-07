namespace MollieResellerApi.Models.Reseller.Account
{
    public class BankAccountEditRequest : BaseRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long PartnerIdCustomer { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Iban { get; set; }

        public string Bic { get; set; }

        public string Bankname { get; set; }

        public string Location { get; set; }
    }
}
