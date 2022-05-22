using System;
using System.Windows;

namespace sea_battle.classes.system
{
    internal class exit
    {
        public bool exit_app_bool()
        {            
            bool res = false;
            var response = MessageBox.Show("Вы действительно хотите выйти?", "Выход...",
                                           MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                res = true;
            }
            return res;
        }
        public void exit_app()
        {
            var response = MessageBox.Show("Вы действительно хотите выйти?", "Выход...",
                                           MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
