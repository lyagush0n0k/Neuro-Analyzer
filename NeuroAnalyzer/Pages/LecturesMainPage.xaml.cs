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
    /// Логика взаимодействия для LecturesMainPage.xaml
    /// </summary>
    public partial class LecturesMainPage : Page
    {
        public LecturesMainPage()
        {
            InitializeComponent();
        }


        private void FirstLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new VideoLecturePage(new VideoLectureClass(
                "https://www.youtube.com/embed/Elvt-w_TKSU",
                "Джон Кехо. Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью. " +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
                ));
            NavigationService.Navigate(page);
        }
        private void SecondLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new VideoLecturePage(new VideoLectureClass(
                "https://www.youtube.com/embed/Pqd9eM_cqi8",
                "Когда ничего не хочется и теряешь веру в себя, что это и как быть?",
                "Негативные мысли и состояния влияют на наше здоровье и качество жизни, имеют свои причины и с ними можно справляться. "
                ));
            NavigationService.Navigate(page);
        }
        private void ThirdLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new VideoLecturePage(new VideoLectureClass(
                "https://www.youtube.com/embed/X4y0kdQ3yWY",
                "Джон Кехо. Как проработать страх в подсознании? Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью.\n" +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
                ));
            NavigationService.Navigate(page);
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void ToBook1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BookPage());
        }
    }
}
