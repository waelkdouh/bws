using Microsoft.AspNetCore.Components;
using Module6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module6.Pages
{
    public class ProductListBase : ComponentBase
    {
        [Inject]
        public IProductsService productsService { get; set; }

    }
}





