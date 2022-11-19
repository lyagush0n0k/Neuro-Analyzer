using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace NeuroAnalyzer.Pages.TreePages
{
    /// <summary>
    /// Логика взаимодействия для TreePageGame.xaml
    /// </summary>
    public partial class TreePageGame : Page
    {
        public TreePageGame()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
