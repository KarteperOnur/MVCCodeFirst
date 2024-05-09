using AspNetCore_MVC_DependencyInjection.Models;

namespace AspNetCore_MVC_DependencyInjection.Repositories.Abstracts
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
