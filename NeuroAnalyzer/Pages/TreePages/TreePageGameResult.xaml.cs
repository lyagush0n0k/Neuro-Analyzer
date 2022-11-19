using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace NeuroAnalyzer.Pages.TreePages
{
    /// <summary>
    /// Логика взаимодействия для TreePageGameResult.xaml
    /// </summary>
    public partial class TreePageGameResult : Page
    {
        public TreePageGameResult()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
