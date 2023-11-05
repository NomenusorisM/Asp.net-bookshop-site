using BookShop.Interfaces;
using BookShop.Models;

namespace BookShop.Db.Repository
{
    public class AuthorRepository : IAuthors
    {
        private readonly ApplicationContext _context;
        public AuthorRepository(ApplicationContext context)
        {
            this._context = context;
        }

        public IEnumerable<Author> AllAuthors => _context.Authors.Select(a => a);

    }
}
