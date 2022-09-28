using Book_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_Library.Pages.BookList
{
    public class DeleteBookModel : PageModel
    {

        private readonly BookDbContext dbContext;
        public DeleteBookModel(BookDbContext db)
        {
            dbContext = db;
        }

        [BindProperty]
        public Book Book { get; set; }
        public int Id { get; set; }
        public void OnGet()
        {
        }

       

    }
}
