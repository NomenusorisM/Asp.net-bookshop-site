using BookShop.Interfaces;
using BookShop.Models;

namespace BookShop.Db.Repository
{
    public class CategoryRepository : IBooksCategory
    {
        private readonly ApplicationContext _context;
        public CategoryRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public IEnumerable<Category> AllCategories => _context.Categories.Select(c => c);
    }
}
