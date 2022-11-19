using System;
using System.Windows;
using System.Windows.Controls;

namespace NeuroAnalyzer.Pages
{
    /// <summary>
    ///     Логика взаимодействия для Port_Selection.xaml
    /// </summary>
    public partial class PortSelection : Page
    {
        public PortSelection()
        {
            InitializeComponent();
            UpdatePorts();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdatePorts();
        }

        private void UpdatePorts()
        {
            port_ComboBox.ItemsSource = SerialInterfaceClass.GetAvailablePorts();
            port_ComboBox.SelectedIndex = 0;
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {

            //TODO: Исправить надо бы
            try
            {
                SerialInterfaceClass.Init();
                SerialInterfaceClass.SetPort(port_ComboBox.SelectedItem.ToString());
                SerialInterfaceClass.StartReading();
                NavigationService.Navigate(new InstructionManual2());
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран порт или его не существует");
                UpdatePorts();
            }
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InstructionManual1());
        }
    }
}