using CodeBehind.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;


namespace CodeBehind.Pages
{ 
    //TODO - Demo CodeBehind: Add PizzaBase and inherit from this class in the Pizza.Razor file
    public partial class PizzaBase : ComponentBase
    {
        protected List<PizzaSpecial> specials;

        protected override void OnInitialized()
        {
            specials = new List<PizzaSpecial>()
            {
                new PizzaSpecial()
                {
                    Id = 1,
                    Name = "Pepperoni",
                    BasePrice = 15,
                    Description = "Pepperoni",
                    ImageUrl = "images/Pepperoni.jpg"
                },

                new PizzaSpecial()
                {
                    Id = 2,
                    Name = "Blaze Pizza",
                    BasePrice = 10,
                    Description = "Blaze Pizza",
                    ImageUrl = "images/Blaze Pizza.PNG"
                }
            };
        }
    }
}
