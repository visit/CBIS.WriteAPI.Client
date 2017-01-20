namespace CBIS.WriteAPI.Client.Models
{ 
    public class OrganizationAddress
    {
        public OrganizationAddress(string street1, string street2, string street3, string postalCode, string city, string state, string countrycode)
        {
            Street1 = street1;
            Street2 = street2;
            Street3 = street3;
            PostalCode = postalCode;
            City = city;
            State = state;
            CountryCode = countrycode;
        }

        public string State { get; set; }

        public string CountryCode { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Street3 { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }
    }
}