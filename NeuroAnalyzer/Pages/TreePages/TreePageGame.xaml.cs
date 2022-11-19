using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
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
            Loaded += TreePageGame_Loaded;
        }

        private void TreePageGame_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Stopwatch sw = new();
                sw.Start();

                while (sw.ElapsedMilliseconds < 20000)
                {
                    Dispatcher.Invoke(() =>
                    {
                        TreeProgressBar.Value = sw.ElapsedMilliseconds;
                    });
                    

                }
            });
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
