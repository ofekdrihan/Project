using SuperMarket.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Backend.Utils
{
    public class FileUtils
    {
        public static void SaveProductsToFile(BindingList<Product> products)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo fi = new FileInfo("products.bin");
            using (var binaryFile = fi.Create())
            {
                bf.Serialize(binaryFile, products);
                binaryFile.Flush();
            }
        }

        public static BindingList<Product> LoadProductsFromFile()
        {
            BindingList<Product> products;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileInfo fi = new FileInfo("products.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    products = (BindingList<Product>)bf.Deserialize(binaryFile);
                }
            } catch (Exception ex)
            {
                products = new BindingList<Product>();
            }
            return products;
        }
    }
}
