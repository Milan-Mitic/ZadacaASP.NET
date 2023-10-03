using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public PizzaViewModel MapToViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.PizzaSize
            };
        }

        public IActionResult Index()
        {
            var pizzaViewModels = StaticDb.Pizzas.Select(pizza => MapToViewModel(pizza)).ToList();

            return View(pizzaViewModels);
        }

        public IActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(p => p.Id == Id);

            var pizzaViewModel = new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.PizzaSize,
                HasExtras = pizza.HasExtras,
                IsOnPromotion = pizza.IsOnPromotion
            };
            if(pizza.HasExtras)
            {
                pizzaViewModel.Price += 10;
            }

            return View(pizzaViewModel);
        }
    }
}
