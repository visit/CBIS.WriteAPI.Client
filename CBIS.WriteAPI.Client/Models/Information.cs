using System.Runtime.Serialization;

namespace CBIS.WriteAPI.Client.Models
{
    public class Information
    {
        public InformationKey Attribute { get; set; }

        public string Value { get; set; }
    }
}