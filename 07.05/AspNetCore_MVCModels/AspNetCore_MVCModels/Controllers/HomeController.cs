using AspNetCore_MVCModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            List<Product> products = new List<Product>()
            {
                new Product{ ID = 1,
                ProductName = "Chai",
                UnitPrice = 18},
                new Product
                {
                     ID = 2,
                ProductName = "Chang",
                UnitPrice = 21
                }
            };


            //Product product = new Product()
            //{
            //    ID = 1,
            //    ProductName = "Chai",
            //    UnitPrice = 18
            //};

         

            //model transfer
            //15 dk
            return View(products);
        }
    }
}
