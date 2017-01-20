using System.Collections.Generic;

namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditOccasion
    {
        public EditOccasion()
        {
        }

        public List<Occasion> Set { get; set; }
        public List<Occasion> Delete { get; set; }
    }
}