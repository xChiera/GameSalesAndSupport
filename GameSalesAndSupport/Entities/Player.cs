using GameSalesAndSupport.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Entities
{
    public class Player : IEntity
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nationalityId { get; set; }
        public DateTime dateofBirth { get; set; }
        public int Age {
            get
            {
                return age;
            }
            set
            {
                age = DateTime.Now.Year-dateofBirth.Year;
            }
        }
        public string nick { get; set; }
        public float balance { get; set; }
        public int age { get; set; }

    }
}
