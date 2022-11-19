using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual3.xaml
    /// </summary>
    public partial class InstructionManual3 : Page
    {
        public InstructionManual3()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual2());
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual4());
        }
    }
}