using Microsoft.AspNetCore.Mvc;

namespace Pizza_Burger_Hub.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
