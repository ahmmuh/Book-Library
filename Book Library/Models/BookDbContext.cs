using Microsoft.EntityFrameworkCore;

namespace Book_Library.Models
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) :base(options)
        {

        }
        public DbSet<Book> Books{ get; set; }
    }
}
