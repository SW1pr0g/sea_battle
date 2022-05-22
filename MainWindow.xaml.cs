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

namespace sea_battle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool exitt = false;
        public MainWindow()
        {
            InitializeComponent();           
        }
        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {            
            mainPanel.Visibility = Visibility.Hidden;
            mainLabel.Visibility = Visibility.Visible;
            exit_Mainbtn.Visibility = Visibility.Visible;
        }
        private void exit_Mainbtn_Click(object sender, RoutedEventArgs e)
        {
            exitt = true;
            classes.system.exit exit = new classes.system.exit();
            exit.exit_app();            
        }       

        private void main_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            mainPanel.Visibility = Visibility.Visible;
            mainLabel.Visibility = Visibility.Hidden;
            exit_Mainbtn.Visibility = Visibility.Hidden;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {                      
            classes.system.exit exit = new classes.system.exit();
            e.Cancel = exit.exit_app_bool();        
        }
    }
}
