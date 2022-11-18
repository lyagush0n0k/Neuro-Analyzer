using System;
using System.Windows;

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

        BookInfo book1;
        BookInfo book2;
        BookInfo book3;
        BookInfo book4;

        public LecturesMain()
        {
            InitializeComponent();
            lecture1 = new VideoLectureClass(
                "https://www.youtube.com/embed/Elvt-w_TKSU",
                "Джон Кехо. Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью. " +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
                );
            lecture2 = new VideoLectureClass(
                "https://www.youtube.com/embed/Pqd9eM_cqi8",
                "Когда ничего не хочется и теряешь веру в себя, что это и как быть?",
                "Негативные мысли и состояния влияют на наше здоровье и качество жизни, имеют свои причины и с ними можно справляться. "
                );
            lecture3 = new VideoLectureClass(
                "https://www.youtube.com/embed/X4y0kdQ3yWY",
                "Джон Кехо. Как проработать страх в подсознании? Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью.\n" +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
                );

            book1 = new BookInfo(
                "captive.apple.com",
                new Uri(@"/Images/Literature1.png", UriKind.RelativeOrAbsolute),
                "");

        }

        private void FirstLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new VideoLecture(lecture1);
            lectures.Show();
        }

        private void SecondLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new VideoLecture(lecture2);
            lectures.Show();
        }
        private void ThirdLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new VideoLecture(lecture3);
            lectures.Show();
        }
    }
}
