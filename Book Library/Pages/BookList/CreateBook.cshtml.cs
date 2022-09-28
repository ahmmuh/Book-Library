using Book_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_Library.Pages.BookList
{
    public class CreateBookModel : PageModel
    {

        private readonly BookDbContext _db;
        public CreateBookModel(BookDbContext dbContext)
        {
            _db = dbContext;
        }

        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Book book)
        {

            if(ModelState.IsValid)
           
            {
                await _db.AddAsync(book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
