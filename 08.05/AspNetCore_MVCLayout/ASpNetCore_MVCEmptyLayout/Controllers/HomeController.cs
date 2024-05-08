using Microsoft.AspNetCore.Mvc;

namespace ASpNetCore_MVCEmptyLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
