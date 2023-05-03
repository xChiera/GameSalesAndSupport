using GameSalesAndSupport.Concrete;
using GameSalesAndSupport.Entities;
using GameSalesAndSupport.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckTheCustomer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.nationalityId), player.firstName.ToUpper(), player.lastName.ToUpper(), player.dateofBirth.Year);
        }
    }
}
