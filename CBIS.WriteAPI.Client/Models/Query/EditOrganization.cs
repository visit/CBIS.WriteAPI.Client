namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditOrganization
    {
        public EditOrganization()
        {
        }

        public string Name { get; set; }
        public string Culture { get; set; }
        public OrganizationAddress Address { get; set; }
    }
}