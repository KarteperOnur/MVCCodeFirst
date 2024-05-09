using AspNetCore_MVC_DependencyInjection.Models;
using AspNetCore_MVC_DependencyInjection.Models.Data;
using AspNetCore_MVC_DependencyInjection.Repositories.Abstracts;

namespace AspNetCore_MVC_DependencyInjection.Repositories.Concretes
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return FakeProductData.Products.ToList();
        }
    }
}
