using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCLayout.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
