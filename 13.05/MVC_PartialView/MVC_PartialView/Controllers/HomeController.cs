using Microsoft.AspNetCore.Mvc;
using MVC_PartialView.Models;
using System.Diagnostics;

namespace MVC_PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       



        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie{Id=1, Title="Movie1"},
                new Movie{Id=2, Title="Movie2"},
                new Movie{Id=3, Title="Movie3"},
            };
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult _TestPartialAction()
        {
            
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
