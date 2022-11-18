using System.Windows;
using System.Windows.Controls;
using NeuroAnalyzer.Pages;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual5.xaml
    /// </summary>
    public partial class Instruction_manual5 : Page
    {
        public Instruction_manual5()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GraphPage());
        }
    }
}