using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual2.xaml
    /// </summary>
    public partial class InstructionManual2 : Page
    {
        public InstructionManual2()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual3());
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            SerialInterfaceClass.StopReading();
            NavigationService.Navigate(new InstructionManual1());
        }
    }
}