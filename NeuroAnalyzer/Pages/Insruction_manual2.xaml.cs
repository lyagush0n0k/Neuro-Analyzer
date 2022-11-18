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
    /// Логика взаимодействия для Insruction_manual2.xaml
    /// </summary>
    public partial class Insruction_manual2 : Page
    {
        public Insruction_manual2()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            InstuctionFrame2.Navigate(new Instruction_manual3());
        }
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            InstuctionFrame2.Navigate(new Instuction_manual1());
        }
    }
}
