using System;
using System.IO;
using System.Linq;

namespace sea_battle.classes.system
{
    internal class load
    {
        public bool language_load()
        {
            bool res = false;
            string language = File.ReadLines("SB_DATA/settings.txt").First().Substring(9);
            if (language == "english")
            {
                res = false;
            }
            else if (language == "russian")
            {
                res=true;
            }
            return res;
        }
        public bool screen_load()
        {
            bool res = false;
            string screen = File.ReadLines("SB_DATA/settings.txt").Skip(1).First().Substring(11);
            if (screen == "on")
            {
                res = true;
            }
            return res;
        }
    }
}
