using BookShop.Models;

namespace BookShop.Interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories {  get; }

    }
}
