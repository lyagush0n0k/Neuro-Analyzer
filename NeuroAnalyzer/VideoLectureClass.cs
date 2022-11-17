using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroAnalyzer
{
    public class VideoLectureClass
    {
        public string URL;
        public string Title;
        public string? Description;

        public VideoLectureClass(string uRL, string title, string? description)
        {
            URL = uRL;
            Title = title;
            Description = description;
        }
        public VideoLectureClass() { }
    }
}
