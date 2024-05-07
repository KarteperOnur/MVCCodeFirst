using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCEmpty.Controllers
{
    public class ProductController:Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
