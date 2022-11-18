﻿using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer
{
    /// <summary>
    ///     Логика взаимодействия для Port_Selection.xaml
    /// </summary>
    public partial class Port_Selection : Page
    {
        public Port_Selection()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Instruction_manual2());
            SerialInterfaceClass.Init();
            SerialInterfaceClass.SetPort("COM4");
            SerialInterfaceClass.StartReading();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Instruction_manual1());
        }
    }
}