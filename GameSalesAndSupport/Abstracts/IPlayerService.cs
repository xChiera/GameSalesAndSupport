using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Abstracts
{
    public interface IPlayerService
    {
        void CreateAccount(Player player, List<Player> list);
        void DeleteAccount(Player player, List<Player> list);
        void UpdateAccount(Player player, Player playerwithnewinfo, List<Player> list);
    }
}
