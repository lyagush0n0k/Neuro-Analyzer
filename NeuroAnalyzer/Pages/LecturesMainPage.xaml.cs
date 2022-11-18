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
            MainFrame.Content = new VideoLecturePage();
        }
        private void SecondLectionButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new LecturesMainPage();
        }
        private void ThirdLectionButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new LecturesMainPage();
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
