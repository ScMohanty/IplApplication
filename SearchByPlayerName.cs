using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class SearchByPlayerName : IComparer<Player>

    {
        public int Compare(Player x, Player y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
