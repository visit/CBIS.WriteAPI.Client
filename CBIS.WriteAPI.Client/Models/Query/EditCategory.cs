using System.Collections.Generic;

namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditCategory
    {
        public EditCategory()
        {
        }

        public List<int> Set { get; set; }
        public List<int> Delete { get; set; }
    }
}