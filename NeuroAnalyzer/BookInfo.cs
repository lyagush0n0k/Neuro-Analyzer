using System;

namespace NeuroAnalyzer
{
    public class BookInfo
    {
        public string Url { get; set; }
        public Uri imageUri { get; set; }
        public string? Description { get; set; }

        public BookInfo() { }
        public BookInfo(string Url, Uri imageUri, string Description)
        {
            this.Url = Url;
            this.imageUri = imageUri;
            this.Description = Description;
        }
    }
}
