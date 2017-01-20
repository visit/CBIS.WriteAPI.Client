using System;

namespace CBIS.WriteAPI.Client.Models
{
    public class MediaTranslation
    {
        public MediaTranslation()
        {
        }

        public MediaTranslation(string culture, string name, string description, string keywords)
        {
            if (string.IsNullOrEmpty(culture))
            {
                throw new ArgumentNullException(nameof(culture));
            }

            this.Name = name;
            this.Description = description;
            this.Keywords = keywords;
            this.Culture = culture;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Keywords { get; set; }

        public string Culture { get; set; }
    }
}