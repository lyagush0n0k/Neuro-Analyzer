using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    /// Логика взаимодействия для PsyhoPage.xaml
    /// </summary>
    public partial class PsyhoPage : Page
    {
        public PsyhoPage()
        {
            InitializeComponent();
        }

        private void PsycoLoaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Stopwatch sw = new();
                sw.Start();
                double alphaLevel = 0;
                int num_samples = 0;
                while (sw.ElapsedMilliseconds < 20000)
                {
                    Dispatcher.Invoke(() => { PsyhoProgress.Value = sw.ElapsedMilliseconds; });
                    int[] spectrum = SerialInterfaceClass.GetSpectrumData();
                    int thisAlpha = 0;
                    for (int i = 5; i < 10; i++) thisAlpha += spectrum[i];
                    alphaLevel += thisAlpha;
                    num_samples++;
                    /*Dispatcher.Invoke(() =>
                    {
                        PsyhoText.Text = thisAlpha.ToString();
                    });*/
                }

                alphaLevel /= num_samples;
                //MessageBox.Show(alphaLevel.ToString());
                Dispatcher.Invoke(() =>
                {
                    if (alphaLevel > 60)
                    {
                        GoodImage.Source = new BitmapImage(new Uri("/Images/GoodGreen.png", UriKind.RelativeOrAbsolute));
                    }
                    else
                    {
                        BadImage.Source = new BitmapImage(new Uri("/Images/UnsatisfactoryRed.png", UriKind.RelativeOrAbsolute));
                    }
                });
            });
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GraphPage());
        }
    }
}