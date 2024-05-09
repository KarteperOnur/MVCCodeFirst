using DependenctInjection_Samples.Models;

namespace DependenctInjection_Samples.Repositories.Abstracts
{
    public interface ICategoryService
    {
        //List
        List<Category> GetCategories();
        //Create
        void CreateCategory(Category category);

    }
}
