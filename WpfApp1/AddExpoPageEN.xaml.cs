using Microsoft.Win32;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddExpoPageEN.xaml
    /// </summary>
    public partial class AddExpoPageEN : Page
    {
        static int topicsCounter = 0;
        public AddExpoPageEN()
        {
            InitializeComponent();
        }

        private void customTimeClick(object sender, RoutedEventArgs e)
        {

            CustomTime timeWindow = new CustomTime(DateFrom.SelectedDate, DateTo.SelectedDate);
              
            timeWindow.Show();
        }
        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            Nullable<bool> result = openFileDialog.ShowDialog();
            if(result.HasValue && result.Value)
            {
                string fileName = openFileDialog.FileName;
                imagePath.Text = fileName;
            }
        }

        private void AddTopicsClick(object sender, RoutedEventArgs e)
        {

            TopicsWindow tw = new TopicsWindow();
            tw.Show();


           /* int col = 2;
            int row = 5;
            int r = row + topicsCounter;
            if (topicsCounter > 6)
            {
                r = row + topicsCounter % 7;
                col = 3;
            }
            
            
            TextBox topic = new TextBox();
            topic.Height=25;
            topic.Width = 300;
            topic.HorizontalAlignment = HorizontalAlignment.Left;
            Grid.SetRow(topic, r);
            Grid.SetColumn(topic, col);
            addEnGrid.Children.Add(topic);
            topicsCounter++;*/
        }
        private void InfoAvailable_Click(object sender, RoutedEventArgs e)
        {
            Grid ticketsGrid = new Grid();
            Grid.SetRow(ticketsGrid, 9);
            Grid.SetColumn(ticketsGrid, 1);
            Grid.SetRowSpan(ticketsGrid, 5);
            Grid.SetColumnSpan(ticketsGrid, 1);
           
        }
        private void InfoNotAvailable_Click(object sender, RoutedEventArgs e)
        {
           
            btnNo.BorderThickness = new Thickness(2);
            btnNo.BorderBrush = Brushes.Green;
            Label l = new Label();
            l.Content = "Message:";
           
            Grid.SetColumn(l, 1);
            Grid.SetRow(l,9);
            l.HorizontalAlignment = HorizontalAlignment.Right;
            l.VerticalAlignment = VerticalAlignment.Top;
            addEnGrid.Children.Add(l);


            TextBox t = new TextBox();
            t.HorizontalAlignment = HorizontalAlignment.Left;
            t.TextWrapping = TextWrapping.Wrap;
            Grid.SetRowSpan(t, 2);
            Grid.SetRow(t, 9);
            Grid.SetColumn(t, 2);
            t.Width = 300;
          
            addEnGrid.Children.Add(t);
        }
    }
}
