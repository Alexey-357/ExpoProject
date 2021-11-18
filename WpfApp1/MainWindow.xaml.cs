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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        Uri enPageUri = new System.Uri("AddExpoPageEN.xaml", UriKind.RelativeOrAbsolute);
       Uri dePageUri = new System.Uri("AddExpoPageDE.xaml", UriKind.RelativeOrAbsolute);
    //   Uri myHelpPageUri = new System.Uri("/BCView;component/Pages/HelpPage.xaml", UriKind.RelativeOrAbsolute);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonEN_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = enPageUri;
            
           
        }
        private void showAddGrid(object sender, RoutedEventArgs e)
        {
            addGrid.Visibility = Visibility.Visible;
        }

        private void ButtonDE_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = dePageUri;
        }
        private void ButtonRU_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
