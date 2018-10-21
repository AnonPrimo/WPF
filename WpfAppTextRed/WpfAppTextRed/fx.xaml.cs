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
using System.Windows.Shapes;

namespace WpfAppTextRed
{
    /// <summary>
    /// Логика взаимодействия для fx.xaml
    /// </summary>
    public partial class fx : Window
    {
        MainWindow mw;

        List<string> coll;


        public fx(MainWindow m)
        {
            InitializeComponent();
            mw = m;
            foreach (var item in coll)
            {
                if (coll != null)
                    lb2.Items.Add(item);

            }

            foreach (var item in mw.names)
            {
                lb1.Items.Add(item);
            }
        }

        private void Check()
        {
            foreach (string item in lb2.Items)
            {
                if (item == "New")
                    mw.New.Visibility = Visibility.Collapsed;
                else
                    mw.New.Visibility = Visibility.Visible;


                if (item == "Open")
                    mw.Open.Visibility = Visibility.Collapsed;
                if (item == "Save")
                    mw.Save.Visibility = Visibility.Collapsed;
                if (item == "SaveAs")
                    mw.SaveAs.Visibility = Visibility.Collapsed;
                if (item == "Copy")
                    mw.Copy.Visibility = Visibility.Collapsed;
                if (item == "Paste")
                    mw.Paste.Visibility = Visibility.Collapsed;
                if (item == "Undo")
                    mw.Undo.Visibility = Visibility.Collapsed;
                if (item == "Redo")
                    mw.Redo.Visibility = Visibility.Collapsed;
                    
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            lb2.Items.Add(lb1.SelectedValue.ToString());
            lb1.Items.Remove(lb1.SelectedValue);                       
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            lb1.Items.Add(lb2.SelectedValue.ToString());
            lb2.Items.Remove(lb2.SelectedValue);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mw.names.Clear();

            foreach (var item in lb2.Items)
            {
                coll.Add(item.ToString());
                //mw.names.Add(item.ToString());
            }

            Check();
           
        }
    }
}
