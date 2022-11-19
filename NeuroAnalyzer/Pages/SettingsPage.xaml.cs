using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            UpdatePorts();
        }

        private void UpdatePorts()
        {
            port_ComboBox.ItemsSource = SerialInterfaceClass.GetAvailablePorts();
            port_ComboBox.SelectedIndex = 0;
        }

        private void ReturnBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}