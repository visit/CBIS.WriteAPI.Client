using System.Collections.Generic;

namespace CBIS.WriteAPI.Client.Models.Query
{
    public class EditInformation
    {
        public EditInformation()
        {
        }

        public List<Information> Set { get; set; }

        public List<InformationKey> Delete { get; set; }
    }
}