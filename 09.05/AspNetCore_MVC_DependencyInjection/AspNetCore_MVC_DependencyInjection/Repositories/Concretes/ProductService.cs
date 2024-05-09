using AspNetCore_MVC_DependencyInjection.Models;
using AspNetCore_MVC_DependencyInjection.Models.Data;
using AspNetCore_MVC_DependencyInjection.Repositories.Abstracts;

namespace AspNetCore_MVC_DependencyInjection.Repositories.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return ProductData.Products.ToList();
        }
    }
}
