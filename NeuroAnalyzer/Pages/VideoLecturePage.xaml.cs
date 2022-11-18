using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuroAnalyzer
{
    /// <summary>
    /// Логика взаимодействия для VideoLecturePage.xaml
    /// </summary>
    public partial class VideoLecturePage : Page
    {
        public VideoLecturePage(VideoLectureClass a)
        {
            InitializeComponent();

            Browser.LoadUrlAsync(a.URL);
            Name.Text = a.Title;
            Description.Text = a.Description;
            this.Title = a.Title;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LecturesMainPage());
        }
    }
}
