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

namespace WpfAppCorectWriter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string s;
        private int posit; 

        public MainWindow()
        {
            InitializeComponent();
            s = "";
            posit = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s = tb1.SelectedText;
            posit = tb1.SelectedText[0];

            tb2.Text = s;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < tb1.Text.Length; ++i)
            {
                if(i == posit)
                tb1.Text += tb2.Text;

            }
            
        }
    }
}
