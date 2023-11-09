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

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
