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
using Microsoft.Win32;
using System.IO;

namespace WpfAppTextRed
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog file_op;
        SaveFileDialog file_save;
        public List<string> names;

        public MainWindow()
        {
            InitializeComponent();
            file_op = new OpenFileDialog();
            file_save = new SaveFileDialog();

            names = new List<string>();
            names.Add("New");
            names.Add("Open");
            names.Add("Save");
            names.Add("SaveAs");
            names.Add("Copy");
            names.Add("Paste");
            names.Add("Undo");
            names.Add("Redo");
            //MenuItem menuItems = new MenuItem();
            //foreach(var item in menuItems.Name.ToList())
            //{
            //    foreach (string n in names)
            //    {
            //        if(menuItems.Name.ToString() == "New")
            //            New.Visibility = Visibility.Collapsed;

            //    }
            //}
            Save.IsEnabled = false;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            fx fx1 = new fx(this);
            fx1.Owner = this;
            fx1.ShowDialog();
            MessageBox.Show(names.ToString());

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Save.IsEnabled = false;
            tb1.Text = "";
        }

        private void CommandBinding_Executed1(object sender, ExecutedRoutedEventArgs e)
        {
            file_op.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
            if (file_op.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(file_op.FileName);
                tb1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void CommandBinding_Executed2(object sender, ExecutedRoutedEventArgs e)
        {
            file_save.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
            if (file_save.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(file_save.FileName);
                writer.WriteLine(tb1.Text);
                writer.Close();
            }           
        }

        private void CommandBinding_Executed3(object sender, ExecutedRoutedEventArgs e)
        {
            switch (MessageBox.Show("Are you shure?", "Confirmation", MessageBoxButton.YesNoCancel))
            {
                case MessageBoxResult.None:
                    break;
                case MessageBoxResult.OK:
                    break;
                case MessageBoxResult.Cancel:
                    break;
                case MessageBoxResult.Yes: this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }

        private void tb1_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (tb1.Text != "")
            {
                Save.IsEnabled = true;
                New.IsEnabled = true;
                New.Visibility = Visibility.Visible;
            }
            else
                Save.IsEnabled = false;

        }
        
    }
}
