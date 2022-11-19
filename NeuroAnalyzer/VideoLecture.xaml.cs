using System.Windows;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для VideoLecture.xaml
    /// </summary>
    public partial class VideoLecture : Window
    {
        public VideoLecture(VideoLectureClass a)
        {
            InitializeComponent();

            Browser.LoadUrlAsync(a.URL);
            Name.Text = a.Title;
            Description.Text = a.Description;
            Title = a.Title;
        }
    }
}