using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual5.xaml
    /// </summary>
    public partial class InstructionManual5 : Page
    {
        public InstructionManual5()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PsyhoPage());
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}