using System;
using System.IO;
using System.Linq;

namespace sea_battle.classes.system
{
    internal class save
    {
        public void user_data(int num_str, string data)
        {
            var readedLines = File.ReadAllLines("SB_DATA/settings.txt").ToList();            
            readedLines.RemoveRange(num_str, 1);
            readedLines.Insert(num_str, data);
            File.WriteAllLines("SB_DATA/settings.txt", readedLines.ToArray());
        }
    }
}
