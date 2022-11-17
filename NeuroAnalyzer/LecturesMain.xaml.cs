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
    /// Логика взаимодействия для LecturesMain.xaml
    /// </summary>
    public partial class LecturesMain : Window
    {
        VideoLectureClass lecture1;
        VideoLectureClass lecture2;
        VideoLectureClass lecture3;

        public LecturesMain()
        {
            InitializeComponent();
            lecture1 = new VideoLectureClass(
                "https://www.youtube.com/embed/Elvt-w_TKSU",
                "Джон Кехо. Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью. " +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время.");
            lecture2 = new VideoLectureClass();
            lecture3 = new VideoLectureClass();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new VideoLecture(lecture1);
            lectures.Show();
        }
    }
}
