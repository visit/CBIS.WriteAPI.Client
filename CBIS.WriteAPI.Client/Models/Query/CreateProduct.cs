namespace CBIS.WriteAPI.Client.Models.Query
{
    public class CreateProduct
    {
        public CreateProduct()
        {
        }

        public string Product { get; set; }
        public string ParentProduct { get; set; }
        public string Name { get; set; }
    }
}