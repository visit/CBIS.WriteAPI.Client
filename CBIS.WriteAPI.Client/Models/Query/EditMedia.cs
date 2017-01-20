using System.Collections.Generic;

namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditMedia
    {
        public EditMedia()
        {
        }

        public List<Media> Set { get; set; }
        public List<string> Delete { get; set; }
    }
}