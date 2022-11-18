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
using System.Windows.Shapes;

namespace NeuroAnalyzer
{
    /// <summary>
    /// Логика взаимодействия для Instruction_manual.xaml
    /// </summary>
    public partial class Instruction_manual : Window
    {
        public Instruction_manual()
        {
            InitializeComponent();
            Hello.Text = "Приветствуем!\r\nДавайте подключим оборудование, следуйте инструкциям на экране.";
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
