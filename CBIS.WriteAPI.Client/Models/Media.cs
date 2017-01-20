using System;

namespace CBIS.WriteAPI.Client.Models
{ 
    public class Media
    {
        public Media(Uri location, MediaType type, bool isMain, string externalRef)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (string.IsNullOrEmpty(externalRef))
            {
                throw new ArgumentNullException(nameof(externalRef));
            }

            Location = location;
            Type = type;
            IsMainMedia = isMain;
            ExternalReference = externalRef;
            Translations = new MediaTranslation[0];
        }

        public MediaTranslation[] Translations { get; set; }

        public string ExternalReference { get; set; }

        public bool IsMainMedia { get; set; }

        public Media(Uri location, MediaType type, bool isMain, string externalRef, MediaTranslation[] translations)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (string.IsNullOrEmpty(externalRef))
            {
                throw new ArgumentNullException(nameof(externalRef));
            }

            if (translations == null)
            {
                throw new ArgumentNullException(nameof(translations));
            }

            Location = location;
            Type = type;
            IsMainMedia = isMain;
            ExternalReference = externalRef;
            Translations = translations;
        }

        public Media(Uri location, MediaType type, bool isMain, string externalRef, string copyright, string filename, string produceBy)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (string.IsNullOrEmpty(externalRef))
            {
                throw new ArgumentNullException(nameof(externalRef));
            }

            Location = location;
            Type = type;
            IsMainMedia = isMain;
            ExternalReference = externalRef;
            CopyrightBy = copyright;
            FileName = filename;
            ProducedBy = produceBy;
            Translations = new MediaTranslation[0];
        }

        public MediaType Type { get; set; }

        public Uri Location { get; set; }

        public string ProducedBy { get; set; }

        public string FileName { get; set; }

        public string CopyrightBy { get; set; }

        public Media(Uri location, MediaType type, bool isMain, string externalRef, MediaTranslation[] translations, string copyright, string filename, string produceBy)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            if (string.IsNullOrEmpty(externalRef))
            {
                throw new ArgumentNullException(nameof(externalRef));
            }

            if (translations == null)
            {
                throw new ArgumentNullException(nameof(translations));
            }

            Location = location;
            Type = type;
            IsMainMedia = isMain;
            ExternalReference = externalRef;
            CopyrightBy = copyright;
            FileName = filename;
            ProducedBy = produceBy;
            Translations = translations;
        }
    }
}