using AspNetCore_MVCModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            {
                ID = 1,
                ProductName = "Chai",
                UnitPrice = 18
            };

            //model transfer
            //15 dk
            return View();
        }
    }
}
