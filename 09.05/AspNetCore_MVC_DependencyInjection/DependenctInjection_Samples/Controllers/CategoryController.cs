using DependenctInjection_Samples.Models;
using DependenctInjection_Samples.Repositories.Abstracts;
using DependenctInjection_Samples.Repositories.Cocnretes;
using Microsoft.AspNetCore.Mvc;

namespace DependenctInjection_Samples.Controllers
{
    public class CategoryController : Controller
    {
        //CategoryService _categoryService= new CategoryService();
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            
            var categories=_categoryService.GetCategories();
            return View(categories);
        }

        public IActionResult Create(Category category)
        {
            _categoryService.CreateCategory(category);
            return View();  
        }
    }
}
