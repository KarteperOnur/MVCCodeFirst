using DependenctInjection_Samples.Repositories.Abstracts;
using DependenctInjection_Samples.Repositories.Cocnretes;
using Microsoft.AspNetCore.Mvc;

namespace DependenctInjection_Samples.Controllers
{
    public class CategoryTestController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryTestController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_categoryService.GetCategories());
        }
    }
}
