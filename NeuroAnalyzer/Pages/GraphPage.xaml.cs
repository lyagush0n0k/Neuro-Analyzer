using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Configurations;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    /// Логика взаимодействия для GraphPage.xaml
    /// </summary>
    public partial class GraphPage : Page
    {
        private Timer graphUpdateTimer;
        private double _graphWidth, _graphHeight;
        
        public ChartValues<MeasureModel> Values { get; set; }
        public ChartValues<int> Values1 { get; set; }
        public ChartValues<double> Values2 { get; set; }

        public GraphPage()
        {
            InitializeComponent();

            Values1 = new ChartValues<int>();
            Values2 = new ChartValues<double>();

            var mapper = Mappers.Xy<MeasureModel>()
                .X(x => x.ElapsedMilliseconds)
                .Y(x => x.Value);

            //save the mapper globally         
            Charting.For<MeasureModel>(mapper);
            
            Values = new ChartValues<MeasureModel>();
            double alphaLevel = 0;
            var sw = new Stopwatch();
            sw.Start();

            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(2);
                    
                    int[] spectrumData = SerialInterfaceClass.GetSpectrumData();

                    //we add the lecture based on our StopWatch instance
                    Values.Add(new MeasureModel
                    {
                        ElapsedMilliseconds = sw.ElapsedMilliseconds,
                        Value = SerialInterfaceClass.graphPoint
                    });

                    Values1.Clear();
                    for (int i = 0; i < 32; i++)
                    {
                        Values1.Add(spectrumData[i]);
                    }

                    int sum = 0;
                    for(int i = 5; i < 10; i++) sum += spectrumData[i];
                    sum *= 3;
                    alphaLevel = 0.03*sum + 0.97*alphaLevel;
                    
                    Values2.Add(alphaLevel);

                    if (Values.Count > 200) Values.RemoveAt(0);
                    if (Values2.Count > 32) Values2.RemoveAt(0);
                }
            });

            DataContext = this;
        }

        //private void RefreshGraph(object? obj)
        //{
        //    Dispatcher.Invoke(() =>
        //    {
        //        StackPanel stackPanel = new()
        //        {
        //            Orientation = Orientation.Horizontal
        //        };
        //        SpectrumGrid.Children.Clear();
        //        Rectangle graphBounds = new()
        //        {
        //            StrokeThickness = 1,
        //            Stroke = Brushes.Black
        //        };
        //        SpectrumGrid.Children.Add(graphBounds);

        //        int[] spectrumData = SerialInterfaceClass.GetSpectrumData();
        //        for (int i = 0; i < 32; i++)
        //        {
        //            stackPanel.Children.Add(new Rectangle()
        //            {
        //                Width = _graphWidth / 32,
        //                Margin = new Thickness(0,0,0,1),
        //                Height = Math.Min(spectrumData[i], _graphHeight),
        //                Fill = Brushes.Aquamarine,
        //                StrokeThickness = 0,
        //                VerticalAlignment = VerticalAlignment.Bottom,
        //                HorizontalAlignment = HorizontalAlignment.Center
        //            });
        //        }
        //        SpectrumGrid.Children.Add(stackPanel);
        //    });
        //}

        private void GridSizeChanged(object sender, RoutedEventArgs e)
        {
            _graphHeight = Math.Max(WindowHeight / 2 - 40, 10);
            _graphWidth = Math.Max(WindowWidth - 40, 10);
        }
        
        public class MeasureModel
        {
            public double ElapsedMilliseconds { get; set; }
            public double Value { get; set; }
        }
    }
}