using SuperMarket.Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    internal class Salty : Snack
    {
        public eSaltyTypes SaltyTypes { set; get; }

        public Salty(string name, double price, double weight, DateTime expiryDate, bool isDairy, bool isSugarFree, bool isGlutenFree, bool isNutsFree, eSaltyTypes saltyTypes) :
            base(name, price, weight, expiryDate, isDairy, isSugarFree, isGlutenFree, isNutsFree)
        {
            SaltyTypes = saltyTypes;
        }
        public override String randomFact()
        {
            return "החטיף הנמכר בישראל הוא הבמבה עם 24 אחוז מכירות מסך כל החטיפים שנמכרים";
        }
    }
}
