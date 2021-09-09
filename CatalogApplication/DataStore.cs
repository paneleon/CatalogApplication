using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApplication
{
    public static class DataStore
    {
        public static Catalog Load(string filePath)
        {
            Catalog catalog = new Catalog();

            string[] allData = File.ReadAllLines(filePath);
            foreach(string data in allData)
            {
                string[] record = data.Split('\t');
                string name = record[0];
                Department department = (Department)Enum.Parse(typeof(Department), record[1], true);
                decimal price = Convert.ToDecimal(record[2]);

                Product product = new Product
                {
                    Name = name,
                    Department = department,
                    Price = price
                };

                catalog.Add(product);
            }
            return catalog;
        }

        public static void Save(Catalog catalog, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                List<Product> products = (List<Product>)catalog.GetAllProducts();
                foreach (Product product in products)
                {
                    writer.WriteLine($"{product.Name}\t{product.Department}\t{product.Price}");
                }
            }
        }
    }
}
