using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для Instruction_manual1.xaml
    /// </summary>
    public partial class Instruction_manual1 : Page
    {
        public Instruction_manual1()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Port_Selection());
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}