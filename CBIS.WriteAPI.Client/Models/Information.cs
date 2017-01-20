using System.Runtime.Serialization;

namespace CBIS.WriteAPI.Client.Models
{
    [KnownType(typeof(InformationBoolean))]
    [KnownType(typeof(InformationInteger))]
    [KnownType(typeof(InformationDouble))]
    [KnownType(typeof(InformationString))]
    public abstract class Information
    {
        public InformationKey Attribute { get; set; }
    }
}