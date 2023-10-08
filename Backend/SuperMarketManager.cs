using SuperMarket.Backend.Model;
using SuperMarket.Backend.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Backend
{
    public class SuperMarketManager
    {
        private static BindingList<Product> products;
        static SuperMarketManager()
        {
            products = FileUtils.LoadProductsFromFile();
            if (products.Count > 0)
            {
                Product.CurrentId = products[products.Count - 1].Id + 1;
            }
        }

        public static void SaveProductsToFile(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveProductsToFile(products);
        }
        public static BindingList<Product> GetProducts()
        {
            return products;
        }
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public static BindingList<T> GetSpecificProducts<T>() where T : Product
        {
            BindingList<T> specificProducts = new BindingList<T>();
            foreach(Product product in products)
            {
                if (product is T)
                {
                    specificProducts.Add((T)product);
                }
            }
            return specificProducts;
        }
    }
}
