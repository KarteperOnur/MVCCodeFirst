using MVC_TagHelpers.Models.Northwind;

namespace MVC_TagHelpers.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        void AddCategory(Category category);

        Category GetCategoryById(int id);

        void UpdateCategory(Category category);

        void DeleteCategory(int id);

    }
}
