using BookShop.Models;

namespace BookShop.Interfaces
{
    public interface IAuthors
    {
        IEnumerable<Author> AllAuthors { get; }
    }
}
