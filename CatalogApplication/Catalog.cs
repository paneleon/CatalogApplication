using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApplication
{
    public class Catalog
    {
        private List<Product> _list = new List<Product>();

        public void Add(Product product)  
        {
            _list.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()    
        {
            return _list;
        }

        public IEnumerable<Product> GetProducts(string filter)  
        {
            IEnumerable<Product> filteredList = _list.Where(product => product.Name.ToLower().Contains(filter.ToLower()));
            return filteredList.ToList();
        }
    }
}
