using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("/ListOrders")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Order/Details/{id?}")]
        public IActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return new EmptyResult();
            }

            return View();
        }

        [Route("JsonData")]
        public IActionResult OrderProperties()
        {
            List<Order> orders = new List<Order>
            {
                new Order{Discount = 10,OrderCost = 5, Id  = "101011", Name = "FirstOne"},
                new Order{Discount = 15,OrderCost = 45, Id  = "113011", Name = "Second"},
                new Order{Discount = 12,OrderCost = 10, Id  = "100001", Name = "Third"},
                new Order{Discount = 5,OrderCost = 5, Id  = "101561", Name = "Fourth"}
            };
            return new JsonResult(orders);
        }
        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
