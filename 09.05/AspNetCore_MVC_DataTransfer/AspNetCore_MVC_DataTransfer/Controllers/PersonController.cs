using AspNetCore_MVC_DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_DataTransfer.Controllers
{
    public class PersonController : Controller
    {
        List<Person> _people = new List<Person>()
        {
            new Person{Firstname="John",Lastname="Doe"},
            new Person{Firstname="Adrew",Lastname="Fuller"}
        };

        List<Category> _categories = new List<Category>
        {
            new Category{CategoryName="Yiyecek"},
            new Category{CategoryName="İçecek"},
            new Category{CategoryName="Kozmetik"}
        };

        public IActionResult Index()
        {
            //Title
            ViewData["Title"] = "Samples";


            //ViewBag
            ViewBag.People=_people;


            //ViewData
            ViewData["Categories"] = _categories;


            return View();
        }
    }
}
