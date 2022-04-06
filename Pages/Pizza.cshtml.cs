using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaCreator.Models;

namespace PizzaCreator.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> mockPizzaDb;

        public PizzaModel()
        {
            this.mockPizzaDb = new List<PizzasModel>()
            {
                new PizzasModel() { ImageTitle = "Margherita", PizzaName = "Margherita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 4 },
                new PizzasModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
                new PizzasModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 6 },
                new PizzasModel() { ImageTitle = "MeatFeast", PizzaName = "Meat Feast", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6 },
                new PizzasModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 6 },
                new PizzasModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushroom = true, FinalPrice = 5 },
                new PizzasModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 2, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 5 },
                new PizzasModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 5 },
                new PizzasModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 6 },
            };
        }

        public void OnGet()
        {
        }
    }
}
