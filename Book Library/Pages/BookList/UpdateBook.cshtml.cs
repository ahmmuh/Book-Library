using Book_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_Library.Pages.BookList
{
    public class UpdateBookModel : PageModel
    {
        private readonly BookDbContext bookDbContext;

        public UpdateBookModel(BookDbContext db)
        {
            bookDbContext = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public int Id { get; set; }
        public async Task OnGet(int id)
        {
            Book = await bookDbContext.Books.FindAsync(id);

        }


        public async Task<IActionResult> OnPost()
        {
            var updatedBook = await bookDbContext.Books.FindAsync(Book.Id);

            if ( updatedBook != null && ModelState.IsValid)
            {

          
                updatedBook.Title = Book.Title;
                updatedBook.ISBN = Book.ISBN;
                updatedBook.Author = Book.Author;

                await bookDbContext.SaveChangesAsync();
                return RedirectToPage("Index");


            }

            return Page();

        }
    }
}
