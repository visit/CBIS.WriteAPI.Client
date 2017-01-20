namespace CBIS.WriteAPI.Client.Models
{
    public class ProductWriteResult
    {
        public ProductWriteResult()
        {
        }

        public ProductWriteResult(string product, bool hasChanged)
        {
            Reference = product;
            HasChanged = hasChanged;
        }

        public string Reference { get; set; }

        public bool HasChanged { get; set; }
    }
}