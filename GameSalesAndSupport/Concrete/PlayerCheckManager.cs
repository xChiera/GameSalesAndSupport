using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckTheCustomer(Player player)
        {
            return true;
        }
    }
}
