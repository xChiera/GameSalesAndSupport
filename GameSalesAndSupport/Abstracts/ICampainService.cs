using GameSalesAndSupport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Abstracts
{
    interface ICampainService
    {
        void IsThereAnyCampain(Player player,Game game, float PriceUpdate);
        void ApplyTheCampain(Player player,Game game,float PriceUpdate);
    }
}
