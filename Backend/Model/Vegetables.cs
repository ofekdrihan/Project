using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.Backend.Enums;


namespace SuperMarket.Backend.Model
{
    [Serializable]
    internal class Vegetables : Product
    {
        public bool IsFresh { set; get; }
        public eVegetables VegType { set; get; }
        public bool IsOrganic { set; get; }

        public Vegetables(string name, double price, double weight, DateTime expiryDate, bool isfresh, eVegetables vegType, bool isOrganic) :
            base(name, price, weight, expiryDate)
        {
            IsFresh = isfresh;
            VegType = vegType;
            IsOrganic = isOrganic;
        }

        public override String randomFact() {
            return "מומלץ לצרוך 5 מנות ירק ביום ובעדיפות ל5 צבעים שונים";
        }
    }
}
