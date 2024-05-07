using AspNetCore_MVCPostBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCPostBack.Controllers
{
    public class HomeController : Controller
    {


        //HttpGet
        //HttpPost

        public IActionResult Index()
        {
            return View();
        }

    }
}
