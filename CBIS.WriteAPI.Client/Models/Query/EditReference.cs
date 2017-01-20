using System.Collections.Generic;

namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditReference
    {
        public EditReference()
        {
        }

        public List<ProductReference> Set { get; set; }
        public List<ProductReference> Delete { get; set; }
    }
}