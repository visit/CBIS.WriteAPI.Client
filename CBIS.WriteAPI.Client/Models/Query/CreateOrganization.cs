namespace CBIS.WriteAPI.Client.Models.Query
{
    public class CreateOrganization
    {
        public CreateOrganization()
        {
        }

        public string Reference { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public OrganizationAddress Address { get; set; }
    }
}