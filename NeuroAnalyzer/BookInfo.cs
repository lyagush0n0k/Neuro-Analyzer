using System;
using System.Windows.Media.Imaging;

namespace NeuroAnalyzer
{
    public class BookInfo
    {
        public string Url { get; set; }
        public BitmapImage image { get; set; }
        public string? Description { get; set; }

        public BookInfo() { }
        public BookInfo(string Url, BitmapImage image, string Description)
        {
            this.Url = Url;
            this.image = image;
            this.Description = Description;
        }
    }
}
