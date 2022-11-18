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
                "Предлагаемая вниманию читателей книга «Психология человека» – вторая в серии «Азбука психологии» и предназначена для школьников. " +
                "Она не похожа на учебник в строгом понимании этого слова. В ней автор знакомит всех, кто интересуется психологией, с ее основами. " +
                "Главное внимание уделено индивидуально-типологическим особенностям человека: направленности, темпераменту, характеру, способностям. " +
                "В книгу включены также психологические упражнения и опыты по развитию внутреннего мира личности, помогающие лучше понять закономерности психики."
            ));

            NavigationService.Navigate(book);
        }

        private void SecondBook_Click(object sender, RoutedEventArgs e)
        {
            BookPage book = new(new BookInfo(
                "http://ipkfp.nspu.ru/file.php/1/Rogov_E.I._-_Nastolnaja_kniga_prakticheskogo_psikhologa_1.pdf",
                new BitmapImage(new Uri("/Images/Literature2.png", UriKind.RelativeOrAbsolute)),
                "«Психология масс и анализ человеческого Я» – один из известнейших трудов Зигмунда Фрейда – считается также одним из парадоксальнейших его произведений. " +
                "Ведь здесь «отец психоанализа» выступает не столько как психоаналитик, сколько как классический психолог, исследующий не столько личностные, " +
                "сколько социальные аспекты развития внутреннего мира человека и скрытых, глубинных мотивов формирования его мироощущения."
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