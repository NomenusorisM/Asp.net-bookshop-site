using BookShop.Interfaces;
using BookShop.Models;
using System.Linq;

namespace BookShop.Db.Repository
{
    public class BookRepository : IAllBooks
    {
        private readonly ApplicationContext _context;

        public BookRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public IEnumerable<Book> AllBooks => _context.Books;

        public IEnumerable<Book> GetBooksByAuthor => _context.Books.Where(x => x.Author != null);

        public Book getObjectBook(int BookId) => _context.Books.FirstOrDefault(b => b.Id == BookId);
    }
}
