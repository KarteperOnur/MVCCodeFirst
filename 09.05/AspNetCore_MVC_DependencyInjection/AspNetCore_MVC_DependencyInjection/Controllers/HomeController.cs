using AspNetCore_MVC_DependencyInjection.Models;
using AspNetCore_MVC_DependencyInjection.Repositories.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore_MVC_DependencyInjection.Controllers
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
            FakeProductService fakeProduct = new FakeProductService();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
