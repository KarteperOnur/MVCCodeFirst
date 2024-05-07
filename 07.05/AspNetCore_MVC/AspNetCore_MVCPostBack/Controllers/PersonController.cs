using AspNetCore_MVCPostBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCPostBack.Controllers
{
    public class PersonController : Controller
    {

        public static List<Person> persons=new List<Person>();




        public IActionResult Index()
        {
            return View(persons);
        }


        [HttpGet]
        //sayfaya yapılan isteklere cevap verir.
       public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //o sayfadan herhangi bir değer gönderildiğinde devreye girer.
        public IActionResult Create(Person person)
        {
            persons.Add(person);
            return RedirectToAction("Index");
        }
    }
}
