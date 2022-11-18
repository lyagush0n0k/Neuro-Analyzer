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

            MainFrame.NavigationService.Navigate(new Uri("/Pages/MainPage.xaml", UriKind.Relative));
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            SerialInterfaceClass.StopReading();
            Application.Current.Shutdown();
        }
    }
}