namespace NeuroAnalyzer
{
    public class VideoLectureClass
    {
        public string? Description;
        public string Title;
        public string URL;

        public VideoLectureClass(string uRL, string title, string? description)
        {
            URL = uRL;
            Title = title;
            Description = description;
        }

        public VideoLectureClass()
        {
        }
    }
}