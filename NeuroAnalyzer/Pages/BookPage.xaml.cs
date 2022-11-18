using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage()
        {
            InitializeComponent();
        }

        public BookPage(BookInfo book)
        {
            InitializeComponent();

            BookImage.Source = book.image;
            Browser.Address = book.Url;
            BookDescription.Text = book.Description;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LecturesMainPage());
        }
    }
}