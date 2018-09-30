using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication2_2909
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private List<NewWin> newWin = new List<NewWin>();
        public List<NewWin> NewWindow
        {
            get { return newWin; }
            set { newWin = value; }
        }
    }
}
