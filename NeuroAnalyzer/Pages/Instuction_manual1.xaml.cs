using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuroAnalyzer
{
    /// <summary>
    /// Логика взаимодействия для Instuction_manual1.xaml
    /// </summary>
    public partial class Instuction_manual1 : Page
    {
        public Instuction_manual1()
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
