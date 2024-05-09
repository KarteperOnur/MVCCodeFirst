namespace AspNetCore_MVC_DependencyInjection.Models.Data
{
    public class FakeProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1,ProductName="test chai",UnitPrice=18},
            new Product { Id = 2,ProductName="test chang",UnitPrice=21},
            new Product { Id = 3,ProductName="test tofu",UnitPrice=15}

        };
    }
}
