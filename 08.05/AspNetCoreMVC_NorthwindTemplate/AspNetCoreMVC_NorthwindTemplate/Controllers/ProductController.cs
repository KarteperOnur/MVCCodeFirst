using AspNetCoreMVC_NorthwindTemplate.Models.Northwind;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_NorthwindTemplate.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _db=new NorthwindContext();
        public IActionResult Detail(int id)//11111589
        {
            if (id >0)
            {
                var product = _db.Products.Find(id);
                if (product != null)
                {

                    return View(product);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
