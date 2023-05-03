using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Concrete
{
    public interface IPlayerCheckService
    {
        bool CheckTheCustomer(Player player);
    }
}
