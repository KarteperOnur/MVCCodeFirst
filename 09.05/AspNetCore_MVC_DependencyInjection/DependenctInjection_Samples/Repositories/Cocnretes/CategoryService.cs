using DependenctInjection_Samples.Models;
using DependenctInjection_Samples.Repositories.Abstracts;

namespace DependenctInjection_Samples.Repositories.Cocnretes
{
    public class CategoryService : ICategoryService
    {
        //Eklenen kategoriler aşağıdaki listede barınacak
        private static List<Category> _categories=new List<Category>();


        //parametreden alınan category _categories'e eklenecek.
        public void CreateCategory(Category category)
        {
            _categories.Add(category);
        }

        //geriye _categories Liste halinde döndürülecek.
        public List<Category> GetCategories()
        {
            return _categories.ToList();
        }
    }
}
