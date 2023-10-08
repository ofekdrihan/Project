using SuperMarket.Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    public class HealthySnack : Snack
    {
        public int gramOfProtein { get; set; }
        public eHealthySnackPurposes HealthySnackPurposes { get; set; }

        public HealthySnack(string name, double price, double weight, DateTime expiryDate, bool isDairy, bool isSugarFree, bool isGlutenFree, bool isNutsFree,
            int gramOfProtein, eHealthySnackPurposes healthySnackPurposes) :
            base(name, price, weight, expiryDate, isDairy, isSugarFree, isGlutenFree, isNutsFree)
        {
            this.gramOfProtein = gramOfProtein;
            HealthySnackPurposes = healthySnackPurposes;
        }
        public override String randomFact()
        {
            return "אדם נדרש לצרוך 1 מ''ג חלבון לכל ק''ג משקל גוף ביום";
        }
    }
}
