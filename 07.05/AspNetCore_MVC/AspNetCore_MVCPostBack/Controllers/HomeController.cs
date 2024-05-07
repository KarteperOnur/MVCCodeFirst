using AspNetCore_MVCPostBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCPostBack.Controllers
{
    public class HomeController : Controller
    {


        //HttpGet
        //HttpPost

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Person person)
        {


            return View();
        }

    }
}
