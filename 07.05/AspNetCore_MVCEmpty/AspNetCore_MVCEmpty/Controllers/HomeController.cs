using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCEmpty.Controllers
{
    public class HomeController:Controller //controller classı istekleri karşılayıp o isteklere ait sayfaların döndürülmesi için kullandığımız class
    {
        #region Metotlar
        ////Index
        //public string Index()
        //{
        //    return "Anasayfa";
        //}


        ////About
        //public string About()
        //{
        //    return "Hakkımızda";
        //}

        ////Contact
        //public string Contact()
        //{
        //    return "İletişim";
        //} 
        #endregion

        //IActionResult


        //Index
        public IActionResult Index()
        {
            //veritabanına bağlan ürünleri getir. 
            return View();
        }

        //Contact
        public IActionResult Contact()
        {
            return View();
        }

        //About
        public IActionResult About()
        {
            return View();
        }

    }
}
