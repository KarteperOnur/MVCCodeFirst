using AspNetCore_MVC_DependencyInjection.Models;
using AspNetCore_MVC_DependencyInjection.Models.Data;
using AspNetCore_MVC_DependencyInjection.Repositories.Abstracts;
using AspNetCore_MVC_DependencyInjection.Repositories.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_DependencyInjection.Controllers
{
    public class ProductController : Controller
    {

        //Dependeny Injection (Bağımlılığın Dahil Edilmesi)
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        public IActionResult Index()
        {

            
            return View(_productService.GetProducts()); 
        }
    }
}
