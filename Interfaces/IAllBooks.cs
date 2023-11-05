using BookShop.Models;

namespace BookShop.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> AllBooks { get; }
        Book getObjectBook(int BookId);
    }
}
