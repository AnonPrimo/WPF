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

            comboBoxPosit.Items.Add("Worker");
            comboBoxPosit.Items.Add("Director");
            comboBoxPosit.Items.Add("SystemAdministrator");
            comboBoxPosit.Items.Add("Programer");
            comboBoxPosit.Items.Add("Cleaner");

            
        }

        private void wpfLoad(object sender, RoutedEventArgs e)
        {
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(checkBox_chi.Checked)
            comboBox_chi.Visibility = Visibility.Visible;
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
    }
}
