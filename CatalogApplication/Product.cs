using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApplication
{
    public class Product
    {
        public Department Department { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
