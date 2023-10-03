using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza> {
        new Pizza()
        {
            Id = 1,
            Name = "Capri",
            Price = 300,
            PizzaSize = PizzaSize.Normal,
            IsOnPromotion = true,
            HasExtras = true
        },
        new Pizza()
        {
            Id = 2,
            Name = "Pepperoni",
            Price = 400,
            PizzaSize = PizzaSize.Normal,
            IsOnPromotion = false,
            HasExtras = true
        },
        new Pizza()
        {
            Id = 3,
            Name = "Margaritha",
            Price = 500,
            PizzaSize = PizzaSize.Family,
            IsOnPromotion = true,
            HasExtras = true
        }
    };

    }
}
