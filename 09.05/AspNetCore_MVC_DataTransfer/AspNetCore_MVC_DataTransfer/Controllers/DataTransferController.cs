using AspNetCore_MVC_DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_DataTransfer.Controllers
{
    public class DataTransferController : Controller
    {
        /*
         ViewBag
        içerisinde küçük çaplı veri saklayan ve bu verileri içerisinde doğrudan object olarak tutan bir mvc nesnesidir.
         

        ViewData
        İçerisinde object olarak küçük verilerin saklandığı ViewBag ile aynı çalışma yapısına sahip nesnedir.

        TempData
        Tempdata içerisinde oluşturulan bir veriyi farklı view'larda da doğrudan görüntülenmesini sağlar.
         */
        public IActionResult Index()
        {
            Person person = new Person { Firstname = "Fatih", Lastname = "Günalp" };


            ViewBag.Person = "Fatih Günalp";
            ViewData["Company"] = "Bilge Adam";


            //ViewBag ve ViewData sadece tanımladığı Actionlar'ın View'larında görüntülenirler.

            TempData["Test"] = "Test Verisi"; //tempdata bir kez tanımlandıktan sonra 4 farklı view'da kullanılabilinir.

            return View(person);
        }

        public IActionResult TestData()
        {
            TempData.Keep();
            return View();
        }

       
    }
}
