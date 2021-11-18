using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CustomTime.xaml
    /// </summary>
    public partial class CustomTime : Window
    {
        string fr;
        string toT;
        string time;
        public CustomTime(DateTime? from, DateTime? to)
        {
            fr = from.Value.ToShortDateString();
            toT = to.Value.ToShortDateString();
            
            InitializeComponent();
            
           
           
            int frDay = Int32.Parse(fr.Substring(0, 2));
            int toDay = Int32.Parse(toT.Substring(0, 2));
            int dif = toDay - frDay + 1;
            for(int i = 0; i < dif; i++)
            {
                
                int day = frDay + i;
                Label l = new Label();
               
                    
              
                string dat = day.ToString() + fr.Substring(2);
                l.Content = dat;
                Grid.SetRow(l, i);
                TextBox timeFrom = new TextBox();

                myGrid.Children.Add(l);
               

            }
        }
        
    }
}
