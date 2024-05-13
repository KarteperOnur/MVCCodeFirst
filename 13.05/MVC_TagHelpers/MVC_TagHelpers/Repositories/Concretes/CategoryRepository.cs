using MVC_TagHelpers.Models.Northwind;
using MVC_TagHelpers.Repositories.Abstracts;

namespace MVC_TagHelpers.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {

        //DbContext Instance
        private NorthwindContext _context = new NorthwindContext();

        public void AddCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCategory(int id)
        {
            var deleted = GetCategoryById(id);
            if (deleted!=null)
            {
                _context.Categories.Remove(deleted);
                _context.SaveChanges();
            }

        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Categories.Find(id);
            return category;
        }

        public void UpdateCategory(Category category)
        {
            var updated = GetCategoryById(category.CategoryId);
            if (updated != null)
            {
                updated.CategoryName = category.CategoryName;
                updated.Description=category.Description;
                _context.SaveChanges();
            }
        }
    }
}
