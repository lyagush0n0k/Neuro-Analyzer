using System;
using System.ComponentModel;
using System.Windows;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
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

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}