using Module6.Interfaces;
using Module6.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Service
{
    public class HardCodedProductsService : IProductsService
    {
        public static List<Product> products = new List<Product>
        {
            new Product {
                Id =1,
                Name = "My Custom Product",
                Description = "Best product!",
                UnitPrice = 40
            },
            new Product {
                Id =2,
                Name = "My Second Custom Product",
                Description = "Second Best product!",
                UnitPrice = 30
            },

        };

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}

