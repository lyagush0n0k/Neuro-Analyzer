using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages.TreePages
{
    /// <summary>
    /// Логика взаимодействия для TreePage.xaml
    /// </summary>
    public partial class TreePage : Page
    {
        public TreePage()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TreePageGame());
        }
    }
}
