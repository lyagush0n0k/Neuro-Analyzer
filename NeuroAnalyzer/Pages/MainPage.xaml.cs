using System.Windows;
using System.Windows.Controls;
using NeuroAnalyzer.Pages;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LectureButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LecturesMainPage());
        }

        private void Button_Neiro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Instruction_manual1());
        }

        private void NeuroTestButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GraphPage());
        }
    }
}