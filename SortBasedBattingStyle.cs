using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
   class SortBasedBattingStyle :IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.BattingStyle.CompareTo(y.BattingStyle);
        }

        
       
    }
}
