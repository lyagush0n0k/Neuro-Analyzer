using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для LecturesMainPage.xaml
    /// </summary>
    public partial class LecturesMainPage : Page
    {
        public LecturesMainPage()
        {
            InitializeComponent();
        }


        private void FirstLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new(new VideoLectureClass(
                "https://www.youtube.com/embed/Elvt-w_TKSU",
                "Джон Кехо. Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью. " +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
            ));
            NavigationService.Navigate(page);
        }

        private void SecondLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new(new VideoLectureClass(
                "https://www.youtube.com/embed/Pqd9eM_cqi8",
                "Когда ничего не хочется и теряешь веру в себя, что это и как быть?",
                "Негативные мысли и состояния влияют на наше здоровье и качество жизни, имеют свои причины и с ними можно справляться. "
            ));
            NavigationService.Navigate(page);
        }

        private void ThirdLectionButton_Click(object sender, RoutedEventArgs e)
        {
            VideoLecturePage page = new(new VideoLectureClass(
                "https://www.youtube.com/embed/X4y0kdQ3yWY",
                "Джон Кехо. Как проработать страх в подсознании? Как избавиться от страха и тревожности?",
                "Преодоление страхов, глубоко укоренившихся в нас, - непростая задача, но она может стать возможностью.\n" +
                "Избавиться от страха можно, и это можно сделать эффективно, но вы должны быть готовы потратить на это время."
            ));
            NavigationService.Navigate(page);
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void FirstBook_Click(object sender, RoutedEventArgs e)
        {
            BookPage book = new(new BookInfo(
                "http://ipkfp.nspu.ru/file.php/1/Rogov_E.I._-_Nastolnaja_kniga_prakticheskogo_psikhologa_1.pdf",
                new BitmapImage(new Uri("/Images/Literature1.png", UriKind.RelativeOrAbsolute)),
                "Наш мир изменился. Несмотря на все блага современной жизни, мы переживаем и волнуемся, как никогда раньше." +
                " Мы наблюдаем мировые катастрофы на экранах гаджетов в режиме реального времени, следим за «идеальной» жизнью других людей и бежим изо всех сил, чтобы остаться на месте." +
                " Именно сейчас нам необходимо понять, можем ли мы что-то сделать, чтобы однажды этот мир не поломал нас окончательно." +
                "Писатель Мэтт Хейг на протяжении многих лет справлялся с депрессией и тревожностью. «Планета нервных» – его честный и проницательный рассказ о том, как контролировать стресс и тревогу, беречь себя и оставаться счастливым в современном мире. "
                
            ));

            NavigationService.Navigate(book);
        }

        private void SecondBook_Click(object sender, RoutedEventArgs e)
        {
            BookPage book = new(new BookInfo(
                "http://ipkfp.nspu.ru/file.php/1/Rogov_E.I._-_Nastolnaja_kniga_prakticheskogo_psikhologa_1.pdf",
                new BitmapImage(new Uri("/Images/Literature2.png", UriKind.RelativeOrAbsolute)),
                "Эта книга – для тех, кто хотел бы научиться находить в кризисах потенциал, уметь превращать проблемы в задачи, видеть в самых разных ситуациях источники сил и ресурсов." +
                " Автор – ученица Виктора Франкла, психотерапевт с огромным опытом – предлагает черпать вдохновение и силы из нескольких замечательных источников. " +
                "Смысл, тишина, юмор, вера, литература… И даже кризис может быть таким источником – если его «правильно приготовить»." +
                " Каждая жизнь, убеждена автор, имеет в себе огромный потенциал. Каждую судьбу реально изменить. " +
                "Замкнутый круг можно разорвать! Опыт Элизабет Лукас и истории людей, которые она рассказывает, свидетельствуют об этом."
            ));

            NavigationService.Navigate(book);
        }

        private void FourthBook_Click(object sender, RoutedEventArgs e)
        {
            BookPage book = new(new BookInfo(
                "http://ipkfp.nspu.ru/file.php/1/Slobodchikov_Isaev_Psikhologija_cheloveka.pdf",
                new BitmapImage(new Uri("/Images/Literature4.png", UriKind.RelativeOrAbsolute)),
                "Данная книга – первая в учебном комплексе – «Основы психологической антропологии» (вторая – «Психология развития человека», третья – «Психология образования человека»)." +
                "Здесь рассмотрены: предмет психологии человека, история и методы его изучения; описаны формы и способы бытия человека в мире, " +
                "представлены основные образы субъективной реальности – индивидный, субъектный, личностный, индивидуальный и универсальный, как они сложились в системе психологического знания. " +
                "Заключает книгу словарь основных понятий."
            ));

            NavigationService.Navigate(book);
        }
    }
}