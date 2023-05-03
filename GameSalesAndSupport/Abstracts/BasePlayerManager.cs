using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Abstracts
{
    public abstract class BasePlayerManager : IPlayerService
    {
        //The CreateAccount function adds players to database(for database we used list here).
        public virtual void CreateAccount(Entities.Player player, List<Player> players)
        {
            player.id = players.Count()+1;
            players.Add(player);
            Console.WriteLine("The Account Succesfully Created...\nHave Fun " + player.nick + "...");
        }

        //The DeleteAccount function deletes players to database(for database we used list here).
        public virtual void DeleteAccount(Player player, List<Player> players)
        {
            foreach (Player oldplayer in players)
            {
                if (isEqualPlayers(oldplayer, player))
                {
                    players.Remove(oldplayer);
                    Console.WriteLine("The Account Succesfully Deleted...\nHoping To See You Again Soon...");
                    break;
                }
            }
        }

        //The UpdateAccount function searches for players in the database and changes their data.(for database we used list here).
        public virtual void UpdateAccount(Player player, Player playerwithnewinfo, List<Player> players)
        {
            foreach (Player oldplayer in players)
            {
                if (isEqualPlayers(oldplayer,player))
                {
                    oldplayer.Age = playerwithnewinfo.Age;
                    oldplayer.firstName = playerwithnewinfo.firstName;
                    oldplayer.lastName = playerwithnewinfo.lastName;
                    oldplayer.nationalityId = playerwithnewinfo.nationalityId;
                    oldplayer.dateofBirth = playerwithnewinfo.dateofBirth;
                    oldplayer.nick = playerwithnewinfo.nick;
                    Console.WriteLine("The Account Succesfully Updated...\nHave Fun...");
                    break;
                }
            }
        }

        bool isEqualPlayers(Player player1, Player player2)
        {
            if(player1==player2)
                return true;
            return false;
        }
    }
}
