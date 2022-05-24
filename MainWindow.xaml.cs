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
    public partial class MainWindow : Window
    {
        bool clicked_main = false;

        #region examplars_classes
        classes.system.load load = new classes.system.load();
        classes.system.exit exit = new classes.system.exit();
        classes.system.save save = new classes.system.save();
        #endregion

        string[] EnglishDict = new string[7]{"Sea Battle", "Press the left mouse button", "Exit", "Start", "Settings", "Back", "FullScreen"};
        string[] RussianDict = new string[7]{"Морской Бой", "Нажмите левую кнопку мыши", "Выход", "Играть", "Настройки", "Назад", "Полный экран"};

        public MainWindow()
        {
            InitializeComponent();                 
            if (load.language_load() == true) 
            { 
                setRussianRB.IsChecked = true;
                setRussian();
            }
            else 
            {
                setEnglishRB.IsChecked = true;
                setEnglish();
            }
            if (load.screen_load() == true)
            {
                fullscreenBox.IsChecked = true;
            }            
        }
        private void exit_Mainbtn_Click(object sender, RoutedEventArgs e)
        {
            exit.exit_app();
        }


        #region main_buttons

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            mainPanel.Visibility = Visibility.Hidden;
            mainLabel.Visibility = Visibility.Visible;
            exit_Mainbtn.Visibility = Visibility.Visible;
            clicked_main = false;
        }
        private void settings_btn_Click(object sender, RoutedEventArgs e)
        {
            mainPanel.Visibility = Visibility.Hidden;
            settingsPanel.Visibility = Visibility.Visible;
        }
        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("начинаем!!!");
        }
        #endregion

        private void settings_back_Click(object sender, RoutedEventArgs e)
        {
            mainPanel.Visibility = Visibility.Visible;
            settingsPanel.Visibility = Visibility.Hidden;
        }


        private void main_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (clicked_main == false)
            {
                mainPanel.Visibility = Visibility.Visible;
                mainLabel.Visibility = Visibility.Hidden;
                exit_Mainbtn.Visibility = Visibility.Hidden;
                clicked_main = true;
            }            
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {                      
            
            e.Cancel = exit.exit_app_bool();        
        }
        private void fullscreenBox_Checked(object sender, RoutedEventArgs e)
        {
            WindowStyle = WindowStyle.None;
            WindowState = WindowState.Maximized;
            
            save.user_data(1, "fullscreen=on");
        }

        private void fullscreenBox_Unchecked(object sender, RoutedEventArgs e)
        {
            WindowStyle = WindowStyle.SingleBorderWindow;
            WindowState = WindowState.Normal;

            save.user_data(1, "fullscreen=off");
        }

        private void setEnglishRB_Checked(object sender, RoutedEventArgs e)
        {
            save.user_data(0, "language=english");
            setEnglish();
        }

        private void setRussianRB_Checked(object sender, RoutedEventArgs e)
        {
            save.user_data(0, "language=russian");
            setRussian();
        }
        private void setEnglish()
        {
            Title = EnglishDict[0];
            mainLabel.Content = EnglishDict[1];
            exit_Mainbtn.Content = EnglishDict[2];
            start_btn.Content = EnglishDict[3];
            settings_btn.Content = EnglishDict[4];
            exit_btn.Content = EnglishDict[5];
            settingsLabel.Content = EnglishDict[4];
            settings_back.Content = EnglishDict[5];
            fullscreenBox.Content = EnglishDict[6];

        }
        private void setRussian()
        {
            Title = RussianDict[0];
            mainLabel.Content = RussianDict[1];
            exit_Mainbtn.Content = RussianDict[2];
            start_btn.Content = RussianDict[3];
            settings_btn.Content = RussianDict[4];
            exit_btn.Content = RussianDict[5];
            settingsLabel.Content = RussianDict[4];
            settings_back.Content = RussianDict[5];
            fullscreenBox.Content = RussianDict[6];
        }
    }
}
