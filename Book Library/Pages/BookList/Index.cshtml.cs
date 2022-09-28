using Book_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Book_Library.Pages.BookList
{
    public class IndexModel : PageModel
    {

        private readonly BookDbContext dbContext;
        public IndexModel(BookDbContext db)
        {
            dbContext = db;

        }

        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await dbContext.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var deletedBook = await dbContext.Books.FindAsync(id);
            if (deletedBook == null)
            {
                return NotFound();
            }
            dbContext.Books.Remove(deletedBook);
            await dbContext.SaveChangesAsync();
            return RedirectToPage("CreateBook");

        }
    }
}
