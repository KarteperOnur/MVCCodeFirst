using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCEmpty.Controllers
{
    public class ProductController:Controller
    {
        public string Index()
        {
            return "Ürün anasayfa";
        }
    }
}
