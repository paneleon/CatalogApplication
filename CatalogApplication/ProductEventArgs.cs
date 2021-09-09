using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApplication
{
    public class ProductEventArgs
    {
        public Product NewProduct { get; }

        public ProductEventArgs(Product product)
        {
            NewProduct = product;
        }
    }
}
