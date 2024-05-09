namespace AspNetCore_MVC_DependencyInjection.Models.Data
{
    public class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1,ProductName="chai",UnitPrice=18},
            new Product { Id = 2,ProductName="chang",UnitPrice=21},
            new Product { Id = 3,ProductName="tofu",UnitPrice=15}

        };
    }
}
