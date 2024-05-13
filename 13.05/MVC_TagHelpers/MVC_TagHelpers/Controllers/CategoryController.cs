using Microsoft.AspNetCore.Mvc;
using MVC_TagHelpers.Models.Northwind;
using MVC_TagHelpers.Repositories.Abstracts;
using MVC_TagHelpers.RequestModels;

namespace MVC_TagHelpers.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //Kategori Listeleme Sayfası
        public IActionResult Index()
        {
            return View(_categoryRepository.GetAllCategories());
        }
        //varsayılan olarak HTTPGET görevini üstlenir.
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        //Kategori Oluşturma Sayfası
        [HttpPost]
        public IActionResult Create(CategoryRequestModel category)
        {

            if (ModelState.IsValid)
            {

                Category newCategory = new Category
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                };

                try
                {
                    _categoryRepository.AddCategory(newCategory);
                    TempData["Success"] = "Kategori Eklendi!";
                }
                catch (Exception ex)
                {
                    TempData["Error"] = ex.Message;
                    throw;
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        //Kategori Detay Sayfası

        public IActionResult Details(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        public IActionResult Update(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            try
            {
                _categoryRepository.UpdateCategory(category);
                TempData["Success"] = "Kategori güncellendi";
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Category deleted=_categoryRepository.GetCategoryById(id);
            return View(deleted);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            try
            {
                _categoryRepository.DeleteCategory(category.CategoryId);
                TempData["Success"] = "Kategori kaldırıldı.";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
               
            }
            return RedirectToAction("Index");
        }
    }
}
