using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            if(SerialInterfaceClass.IsOpen())
            {
                SerialInterfaceClass.StopReading();
            }
        }

        private void LectureButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LecturesMainPage());
        }

        private void Button_Neuro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual1());
        }

        private void ToSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage());
        }

        private void ToPsycho_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PsychoTest());
        }
    }
}