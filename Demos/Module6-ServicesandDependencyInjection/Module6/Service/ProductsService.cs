using Module6.Interfaces;
using Module6.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module5.Service
{
    public class ProductsService : IProductsService
    {
        public List<Product> GetAllProducts()
        {
            //  implementation goes here...
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Blazor Rocks",
                    UnitPrice = 1000,
                    Description = "Best Course"
                },
                new Product
                {
                    Id = 2,
                    Name = "Blazor 101",
                    UnitPrice = 500,
                    Description = "Highly Recommended for new comers"
                }
            };
        }
    }
}
