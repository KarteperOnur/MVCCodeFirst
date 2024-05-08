using Microsoft.AspNetCore.Mvc;

namespace ASpNetCore_MVCEmptyLayout.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
