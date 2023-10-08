using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarket.Backend.Enums;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    internal class Meat : Product
    {
        public bool isFresh { set; get; }
        public eMeatTypes MeatTypes { set; get; }

        public Meat(string name, double price, double weight, DateTime expiryDate, bool Isfresh, eMeatTypes meatTypes) :
            base(name, price, weight, expiryDate)
        {
            MeatTypes = meatTypes;
            isFresh = Isfresh;
        }

        public override String randomFact()
        {
            return "ישראל נמצאת במקום הרביעי מבחינת צריכת בשר לנפש. מקום אחד מתחת לארגנטינה";
        }
    }
}
