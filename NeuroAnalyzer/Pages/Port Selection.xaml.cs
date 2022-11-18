using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для Port_Selection.xaml
    /// </summary>
    public partial class PortSelection : Page
    {
        public PortSelection()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual2());
            SerialInterfaceClass.Init();
            SerialInterfaceClass.SetPort("COM4");
            SerialInterfaceClass.StartReading();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual1());
        }
    }
}