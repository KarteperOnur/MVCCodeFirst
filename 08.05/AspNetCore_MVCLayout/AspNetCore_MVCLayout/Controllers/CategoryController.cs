using AspNetCore_MVCLayout.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCLayout.Controllers
{
    public class CategoryController : Controller
    {

       






        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            CategoryData._categories.Add(category);
            return RedirectToAction("Index", "Home");
        }
    }
}
