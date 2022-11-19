using System.Windows;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для LecturesMain.xaml
    /// </summary>
    public partial class LecturesMain : Window
    {
        private readonly VideoLectureClass lecture1;
        private readonly VideoLectureClass lecture2;
        private readonly VideoLectureClass lecture3;
        private BookInfo book1;
        private BookInfo book2;
        private BookInfo book3;
        private BookInfo book4;

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
        }

        private void FirstLectureButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new(lecture1);
            lectures.Show();
        }

        private void SecondLectureButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new(lecture2);
            lectures.Show();
        }

        private void ThirdLectureButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecture lectures = new(lecture3);
            lectures.Show();
        }
    }
}