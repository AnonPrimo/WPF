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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAnceta
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FillCb(comboBox_chi);
            FillCb(comboBox_eng);
            FillCb(comboBox_fran);
            FillCb(comboBox_germ);
            FillCb(comboBox_ital);
            FillCb(comboBox_jap);
            FillCb(comboBox_rus);
            FillCb(comboBox_ukr);

            comboBoxPosit.Items.Add("Робітник");
            comboBoxPosit.Items.Add("Директор");
            comboBoxPosit.Items.Add("Сисадмін");
            comboBoxPosit.Items.Add("Програміст");
            comboBoxPosit.Items.Add("Прибиральник");
        }

        private void FillCb(ComboBox c)
        {
            c.Items.Add("Професійний");
            c.Items.Add("Середній");
            c.Items.Add("Низький");
            c.Items.Add("Лише розмовна");
            c.Items.Add("Лише письмо");
        }
        
        private void wpfMouseMove(object sender, RoutedEventArgs e)
        {
            CheckCheckBox(checkBox_chi, comboBox_chi);
            CheckCheckBox(checkBox_eng, comboBox_eng);
            CheckCheckBox(checkBox_ukr, comboBox_ukr);
            CheckCheckBox(checkBox_rus, comboBox_rus);
            CheckCheckBox(checkBox_ital, comboBox_ital);
            CheckCheckBox(checkBox_jap, comboBox_jap);
            CheckCheckBox(checkBox_fran, comboBox_fran);
            CheckCheckBox(checkBox_germ, comboBox_germ);
        }

        private void CheckCheckBox(CheckBox ch, ComboBox co)
        {
            if ((bool)ch.IsChecked)
                co.Visibility = Visibility.Visible;
            else
                co.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вашу анкету прийнято!");
            Close();
        }

        private void textBoxKeyPress(object sender, TextCompositionEventArgs e)
        {
            short value;
            if (Int16.TryParse(e.Text, out value))
                e.Handled = true;
            if (e.Text == " ")
                e.Handled = true;
        }
        
        private void textBoxNumbers(object sender, TextCompositionEventArgs e)
        {
            short value;
            if (!Int16.TryParse(e.Text, out value))
                e.Handled = true;
            if (e.Text == " ")
                e.Handled = true;
        }
        private void spaceError(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

    }
}
