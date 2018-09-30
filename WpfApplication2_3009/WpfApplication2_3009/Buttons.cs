using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication2_3009
{
    class Buttons : Button
    {
        public static RoutedEvent MyButtonClickEvent;
        
        static Buttons()
        {
            MyButtonClickEvent = EventManager.RegisterRoutedEvent("MyButtonClick",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(Buttons));
            
            
        }



        public event RoutedEventHandler MyButtonClick
        {
            add { AddHandler(MyButtonClickEvent, value); }
            remove { RemoveHandler(MyButtonClickEvent, value); }
        }


        protected override void OnClick()
        {
            base.OnClick();

            RoutedEventArgs args = new RoutedEventArgs(Buttons.MyButtonClickEvent, this);

            RaiseEvent(args);
        }
    }
}
