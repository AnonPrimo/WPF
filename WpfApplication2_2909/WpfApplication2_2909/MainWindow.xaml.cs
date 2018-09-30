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

namespace WpfApplication2_2909
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            for (int i = 0; i < 100; i++)
            {

           
            NewWin nw = new NewWin();

            nw.Owner = this;

            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;

            nw.Content = i.ToString();
            nw.Top = (rnd.Next((int)screenHeight));
            nw.Left = (rnd.Next((int)screenWidth));

            nw.Show();

            (Application.Current as App).NewWindow.Add(nw);
            }

            

        }

     

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (NewWin nw in ((App)Application.Current).NewWindow)
            {
                Color randomColor = Color.FromRgb((byte)rnd.Next(100,256), (byte)rnd.Next(180, 256), (byte)rnd.Next(200, 256));
                 nw.Background = new SolidColorBrush(randomColor);

                double screenHeight = SystemParameters.FullPrimaryScreenHeight;
                double screenWidth = SystemParameters.FullPrimaryScreenWidth;

                nw.Top += 5;
                nw.Left += 5;


            }
        }
    }
}
