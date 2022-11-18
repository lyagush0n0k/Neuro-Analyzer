﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    /// Логика взаимодействия для PsychoTest.xaml
    /// </summary>
    public partial class PsychoTest : Page
    {
        string[] questions = { "Чаще всего я предпочитаю скрывать свои истинные чувства от других людей",
            "Если я в чем-то уверен - то я делаю это, не нуждаясь ни в чьих советах",
            "Необходимость отстаивать свою точку зрения меня утомляет",
            "Я откровенен со своими близкими, даже когда знаю, что мои слова им не слишком понравятся",
            "Большинство моих успехов -результат игры случая или дружеской помощи",
            "Я доверяю своим собственным впечатлениям, даже если они не совпадают с мнением других",
            "Я отказываюсь от рискованного мероприятия, если окружающие начинают активно меня отговаривать",
            "Я думаю, что я ничуть не хуже других",
            "Мне неприятно копаться в собственных чувствах и мыслях",
            "Я принес много пользы другим людям"};
        int sum = 0, i = 1;

        public PsychoTest()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (i != questions.Length)
            {
                question.Text = questions[i];
            }
            i++;
            if ((i % 2 == 0) && (Yes.IsChecked == true))
            {
                sum++;
            }
            else if ((i % 2 != 0) && (No.IsChecked == true))
            {
                sum++;
            }
            if (i == questions.Length + 1)
            {
                Yes.Visibility= Visibility.Hidden;
                No.Visibility = Visibility.Hidden;
                ToNext_btn.Visibility = Visibility.Hidden;
                if (sum <=2)
                {
                    question.Text = "Ваша психологическая устойчивость гораздо ниже среднего, поэтому вы зависимы от мнения других людей. Вы не можете спокойно воспринимать чужой успех, потому что не верите в свой. Вы сомневаетесь в добрых намерениях других и думаете, что люди с радостью сделали бы вам гадость, если бы у них появилась такая возможность.";
                }
                else if ((sum > 2)&&(sum < 5))
                {
                    question.Text = "Ваша психологическая устойчивость на среднем уровне или немного ниже среднего. Вы слишком критично относитесь к себе и от этого игнорируете свои достижения или даже забываете о них, зато хорошо помните неудачи. Это подрывает вашу веру в свои силы. Недостаток веры в себя объясняет, почему вы редко проводите много времени, думая о себе, — вы боитесь, что разные неприятности всплывут в памяти.";
                }
                else if ((sum >= 5) && (sum <= 7))
                {
                    question.Text = "Ваша психологическая устойчивость выше средней, поэтому вы способен высказать собственное мнение, даже если оно расходится с общепринятым. Вы верите в действие, а не в ожидание, в силу воли, а не во всеобщее согласие.";
                }
                else if (sum >= 8)
                {
                    question.Text = "Ваша психологическая устойчивость очень высока.";
                }
            }
        }
    }
}
