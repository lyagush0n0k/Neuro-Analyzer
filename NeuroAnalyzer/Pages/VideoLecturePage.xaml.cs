using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для VideoLecturePage.xaml
    /// </summary>
    public partial class VideoLecturePage : Page
    {
        public VideoLecturePage(VideoLectureClass a)
        {
            InitializeComponent();

            Browser.LoadUrlAsync(a.URL);
            Name.Text = a.Title;
            Description.Text = a.Description;
            Title = a.Title;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LecturesMainPage());
        }
    }
}