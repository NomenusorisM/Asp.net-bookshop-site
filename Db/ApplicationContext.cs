using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Db
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; }
        public DbSet<Category> Categories { get; }
        public DbSet<Author> Authors { get; }
    }
}
