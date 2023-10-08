using SuperMarket.Backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Model
{
    [Serializable]
    public abstract class Product
    {
        public string Type { get { return GetType().Name; } }
        public static int LastId { set; get; }
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public double Weight { set; get; }
        public DateTime expiryDate { set; get; }
        public static int CurrentId { set; get; }

        protected Product(string name, double price, double weight, DateTime expiryDate)
        {
            Id = CurrentId;
            CurrentId++;
            Name = name;
            Price = price;
            Weight = weight;
            this.expiryDate = expiryDate;
        }

        public abstract String randomFact();

    }
}
