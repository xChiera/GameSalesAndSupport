using GameSalesAndSupport.Abstracts;
using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Concrete
{
    internal class PlayerManager:BasePlayerManager
    {
        IPlayerCheckService _customerCheckService;
        public PlayerManager(IPlayerCheckService customerCheckService)
        {
            this._customerCheckService = customerCheckService;
        }
        public override void CreateAccount(Player player,List<Player> players)
        {
            if (_customerCheckService.CheckTheCustomer(player))
            { base.CreateAccount(player,players); }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
        public override void DeleteAccount(Player player,List<Player> players)
        {
            if (_customerCheckService.CheckTheCustomer(player))
            { base.DeleteAccount(player,players); }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
        public override void UpdateAccount(Player player, Player playerwithnewinfo, List<Player> players)
        {
            if (_customerCheckService.CheckTheCustomer(player))
            { base.UpdateAccount(player, playerwithnewinfo,players); }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
    }
}
