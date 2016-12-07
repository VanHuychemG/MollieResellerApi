namespace MollieResellerApi.Models.Reseller.Account
{
    public class AccountEditRequest : BaseRequest
    {
        public bool Testmode { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Zipcode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string RegistrationNumber { get; set; }

        public LegalForm LegalForm { get; set; }

        public string Representative { get; set; }

        public string BillingAddress { get; set; }

        public string BillingZipcode { get; set; }

        public string BillingCity { get; set; }

        public string BillingCountry { get; set; }

        public string BankaccountIban { get; set; }

        public string BankaccountBic { get; set; }

        public string BankaccountBankname { get; set; }

        public string BankaccountLocation { get; set; }

        public string VatNumber { get; set; }
    }
}
