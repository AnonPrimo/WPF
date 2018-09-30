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

namespace WpfApplication2_3009
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;
        public MainWindow()
        {
            rnd = new Random();
            InitializeComponent();
        }

        private void ClickButt(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(Name);
            Color randomColor = Color.FromRgb((byte)rnd.Next(100, 256), (byte)rnd.Next(180, 256), (byte)rnd.Next(200, 256));
            (sender as Button).Background = new SolidColorBrush(randomColor);
        }
    }
}
