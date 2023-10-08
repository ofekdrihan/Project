using SuperMarket.Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    internal class Chocolate : Snack
    {
        public int CocoaPrecent { get; set; }
        public eChocolateKinds ChocolateKind { get; set; }
        public eChocolateExtras ChocolateExtras { get; set; }

        public Chocolate(string name, double price, double weight, DateTime expiryDate, bool isDairy, bool isSugarFree, bool isGlutenFree, bool isNutsFree,
            int cocoaPrecent, eChocolateKinds chocolateKind, eChocolateExtras chocolateExtras) :
            base(name, price, weight, expiryDate, isDairy, isSugarFree, isGlutenFree, isNutsFree)
        {
            CocoaPrecent = cocoaPrecent;
            ChocolateKind = chocolateKind;
            ChocolateExtras = chocolateExtras;
        }
        public override String randomFact()
        {
            return "שוקולד אהוב וממכר מאחר והוא סם טבעי. מעלה את רמות תרכובת הסרוטונין במוח וגורם לתחושת נעימות ושיפור במצב הרוח";
        }
    }
}
