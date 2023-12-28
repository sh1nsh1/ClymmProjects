using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        public OrderController(IAllOrders allOrders)
        {
            IAllOrders _allOrders = allOrders; 
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order, Character Char)
        {
            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order,Char);
                return RedirectToAction("Complete");
            }
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Title = "Заказ сохранён";
            return View();
        }
    }
}
