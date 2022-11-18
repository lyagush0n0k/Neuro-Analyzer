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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            //double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            //this.Top = (screenHeight - this.Height) / 0x00000002;
            //this.Left = (screenWidth - this.Width) / 0x00000002;
            MainFrame.NavigationService.Navigate(new Uri("/Pages/MainPage.xaml", UriKind.Relative));
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
