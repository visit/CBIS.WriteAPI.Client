using System;
using System.Linq;

namespace CBIS.WriteAPI.Client.Models
{
    public class ProductReference
    {
        [Obsolete("Serialization")]
        public ProductReference()
        {
        }

        public ProductReference(string reference)
        {
            var tab = reference.Split(':');
            if (tab.Count() != 2)
            {
                throw new InvalidOperationException("Invalid format for reference: " + reference);
            }

            LocalName = tab[1];
            SubSystem = tab[0];

            this.Validate();
        }

        public ProductReference(string subSystem, string localName)
        {
            LocalName = localName;
            SubSystem = subSystem;
        }

        public string LocalName { get; set; }

        public string SubSystem { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(this.LocalName))
            {
                throw new InvalidOperationException("LocalName is missing");
            }

            if (!IsOkName(this.LocalName))
            {
                throw new InvalidOperationException("LocalName contains incorrect characters (':', ' ')");
            }

            if (string.IsNullOrEmpty(this.SubSystem))
            {
                throw new InvalidOperationException("SubSystemName is missing");
            }

            if (!IsOkName(this.SubSystem))
            {
                throw new InvalidOperationException("SubSystem contains incorrect characters (':', ' ')");
            }
        }

        private static readonly char[] InvalidChars = new[] { ':', ' ' };

        private bool IsOkName(string name)
        {
            return name.IndexOfAny(InvalidChars) < 0;
        }

        public override string ToString()
        {
            return SubSystem + ":" + LocalName;
        }
    }
}