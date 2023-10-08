using SuperMarket.Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    public abstract class Snack : Product
    {
        public bool IsDairy { get; set; }
        public bool IsSugarFree { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsNutsFree { get; set; }

        public Snack(string name, double price, double weight, DateTime expiryDate, bool isDairy, bool isSugarFree, bool isGlutenFree, bool isNutsFree) :
            base(name, price, weight, expiryDate)
        {
            IsDairy = isDairy;
            IsSugarFree = isSugarFree;
            IsGlutenFree = isGlutenFree;
            IsNutsFree = isNutsFree;
        }
    }
}
