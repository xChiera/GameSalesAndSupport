using GameSalesAndSupport.Abstracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesAndSupport.Entities
{
    public class Game:IEntity
    {
        public string name;
        public string version;
        public string ID;
        public string[] categories;
        public string developer;
        public string publisher;
        public DateTime releaseDate;
        public float baseGamePrice;
        public float priceWithCampain;
        public int ageLimit;
        public bool hasPlayerThisGame;
        public bool hasCampain;
    }
}
