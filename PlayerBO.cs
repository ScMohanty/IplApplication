using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
  class PlayerBO
    {
        public Player[] SearchByPlayerName1(Player[] playerDetails )
        {
            SearchByPlayerName searchbyplayername = new SearchByPlayerName();
            Array.Sort(playerDetails, searchbyplayername);
            return playerDetails;
        }
        public Player[] SearchByBattingStyle1(Player[] playerDetails)
        {
            SortBasedBattingStyle searchbybattingstyle = new SortBasedBattingStyle();
            Array.Sort(playerDetails, searchbybattingstyle);
            Array.Reverse(playerDetails);
            


            return playerDetails;
        }

    }
}
