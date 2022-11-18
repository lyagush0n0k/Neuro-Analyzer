using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для GraphPage.xaml
    /// </summary>
    public partial class GraphPage : Page
    {
        private double _graphWidth, _graphHeight;
        private Timer graphUpdateTimer;

        public GraphPage()
        {
            InitializeComponent();

            SpectrumGrid.Height = mainStack.Height / 2;
            GraphGrid.Height = mainStack.Height / 2;
        }

        private void GraphLoaded(object sender, RoutedEventArgs e)
        {
            graphUpdateTimer = new Timer(RefreshGraph, new AutoResetEvent(false), 0, 10);
        }

        private void RefreshGraph(object? obj)
        {
            Dispatcher.Invoke(() =>
            {
                StackPanel stackPanel = new()
                {
                    Orientation = Orientation.Horizontal
                };
                SpectrumGrid.Children.Clear();
                Rectangle graphBounds = new()
                {
                    Width = _graphWidth,
                    Height = _graphHeight,
                    Fill = Brushes.White,
                    StrokeThickness = 1,
                    Stroke = Brushes.Black
                };
                SpectrumGrid.Children.Add(graphBounds);

                int[] spectrumData = SerialInterfaceClass.GetSpectrumData();
                for (var i = 0; i < 32; i++)
                    stackPanel.Children.Add(new Rectangle
                    {
                        Width = _graphWidth / 32,
                        Margin = new Thickness(0, 0, 0, 1),
                        Height = Math.Min(spectrumData[i], _graphHeight),
                        Fill = Brushes.Aquamarine,
                        StrokeThickness = 0,
                        VerticalAlignment = VerticalAlignment.Bottom,
                        HorizontalAlignment = HorizontalAlignment.Center
                    });
                SpectrumGrid.Children.Add(stackPanel);
            });
        }

        private void GridSizeChanged(object sender, RoutedEventArgs e)
        {
            _graphHeight = Math.Max(WindowHeight / 2 - 40, 10);
            _graphWidth = Math.Max(WindowWidth - 40, 10);
        }
    }
}