using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class dumpProduct : IProductRepo
    {
        public List<Product> ToList()
        {
            var products = new List<Product>();

            products.Add(new Product { Id = 1, Product = "Melk"});
            products.Add(new Product { Id = 2, Product = "Vla" });
            products.Add(new Product { Id = 3, Product = "Boter" });
            products.Add(new Product { Id = 4, Product = "Kaas" });

            return products;
        }
    }
}
