using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

          
           
            PlayerBO obj_playerBO = new PlayerBO();

            Console.WriteLine("ENTER THE NUMBER OF TEAM which YOU WANT TO ENTER");
            int no_oF_Team = Convert.ToInt32(Console.ReadLine()); 
            Player[] playerInfo = new Player[no_oF_Team];
            for (int i=0;i< no_oF_Team;i++)
            {
       Console.WriteLine("ENETER THE DETAILS BASED ON GIVEN FORMAT -string teamName, string country, int id, string name, int age, string battingStyle, string bowlingStyle");
              string playerDetails = Console.ReadLine();
               // string[] players = playerDetails.Split(',');
                Player p = Player.createPlayer(playerDetails);
                playerInfo[i] = p;
            }
            Player[] sortedPlayerDetails = null;

            Console.WriteLine("ENTER 1 TO SORT THE ORDER OF PLAER BASED ON NAME/ENTER 2 TO SORT THE ORDER OF PLAYER BASED ON BATTINGSTYLE");
            int choice = Convert.ToInt32(Console.ReadLine());
            //int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("ENTER THE NAME PLEASE");
                    sortedPlayerDetails = obj_playerBO.SearchByPlayerName1(playerInfo);
                    break;

                case 2:
                    sortedPlayerDetails = obj_playerBO.SearchByBattingStyle1(playerInfo);
                    break;
                default:
                    Console.WriteLine("Invalid Choice , ReRun ur application");
                    break;
            }

            if (sortedPlayerDetails != null)
            {
                foreach (var item in sortedPlayerDetails)
                {
                    Console.WriteLine(item);
                }
            }
        }


    }
    }

