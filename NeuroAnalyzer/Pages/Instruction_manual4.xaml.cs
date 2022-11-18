using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual4.xaml
    /// </summary>
    public partial class Instruction_manual4 : Page
    {
        public Instruction_manual4()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Instruction_manual3());
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Instruction_manual5());
        }
    }
}