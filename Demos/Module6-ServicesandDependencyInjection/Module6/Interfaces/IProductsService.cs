using Module6.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module6.Interfaces
{
    public interface IProductsService
    {
        List<Product> GetAllProducts();
    }
}
