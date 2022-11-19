using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для PsychoTest.xaml
    /// </summary>
    public partial class PsychoTest : Page
    {
        private readonly string[] questions =
        {
            "Нередко мне кажутся безвыходными положения, из которых все-таки можно найти выход.",
            "Неприятности меня сильно расстраивают, я падаю духом.",
            "При больших неприятностях я склонен без достаточных оснований винить себя.",
            "Несчастья и неудачи ничему меня не учат.",
            "Я часто отказываюсь от борьбы, считая ее бесплодной.",
            "Я нередко чувствую себя беззащитным.",
            "Иногда у меня бывает состояние отчаяния.",
            "Я чувствую растерянность перед трудностями.",
            "В трудные минуты жизни иногда веду себя по-детски, хочу, чтобы пожалели.",
            "Считаю недостатки своего характера неисправимыми."
        };

        private int sum, i = 1;

        public PsychoTest()
        {
            InitializeComponent();
        }

        private void Rtn_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (i != questions.Length) question.Text = questions[i];
            i++;
            if (i % 2 == 0 && Yes.IsChecked == true)
                sum++;
            else if (i % 2 != 0 && No.IsChecked == true) sum++;

            if (i != questions.Length + 1) return;
            Yes.Visibility = Visibility.Hidden;
            No.Visibility = Visibility.Hidden;
            ToNext_btn.Visibility = Visibility.Hidden;
            Rtn_Btn.Visibility = Visibility.Visible;
            if (sum >= 8)
                question.Text =
                    "Ваша психологическая устойчивость гораздо ниже среднего, поэтому вы зависимы от мнения других людей. Вы не можете спокойно воспринимать чужой успех, потому что не верите в свой. Вы сомневаетесь в добрых намерениях других и думаете, что люди с радостью сделали бы вам гадость, если бы у них появилась такая возможность.";
            else if (sum >= 5 && sum <= 7)
                question.Text =
                    "Ваша психологическая устойчивость на среднем уровне или немного ниже среднего. Вы слишком критично относитесь к себе и от этого игнорируете свои достижения или даже забываете о них, зато хорошо помните неудачи. Это подрывает вашу веру в свои силы. Недостаток веры в себя объясняет, почему вы редко проводите много времени, думая о себе, — вы боитесь, что разные неприятности всплывут в памяти.";
            else if (sum > 2 && sum < 5)
                question.Text =
                    "Ваша психологическая устойчивость выше средней, поэтому вы способен высказать собственное мнение, даже если оно расходится с общепринятым. Вы верите в действие, а не в ожидание, в силу воли, а не во всеобщее согласие.";
            else if (sum <= 2) question.Text = "Ваша психологическая устойчивость очень высока.";
        }
    }
}