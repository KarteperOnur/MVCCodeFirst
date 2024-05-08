using AspNetCore_MVCLayout.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View(CategoryData._categories.ToList());
        }
    }
}
