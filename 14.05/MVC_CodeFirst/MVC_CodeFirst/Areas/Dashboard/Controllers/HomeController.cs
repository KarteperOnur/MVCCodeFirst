using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Areas.Dashboard.Models;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        //private readonly IMovieService _movieService;
        //public HomeController(IMovieService movieService)
        //{
        //    _movieService = movieService;
        //}
        public IActionResult Index()
        {
            //Service datasından gelecek!

            var viewModelList = new List<MovieDashboardViewModel>();

            for (int i = 1; i < 50; i++)
            {
                var movie = new MovieDashboardViewModel();

                movie.Id = i;
                movie.Name = $"Film {i}";

                movie.Description = $"Açıklama {i}";

                viewModelList.Add(movie);
            }

            var result = viewModelList.OrderByDescending(p => p.Id).Take(4).ToList();

            //var result = _movieService.GetDashboardMovies();

            return View(result);
        }
    }
}
