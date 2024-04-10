using Bookclub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    [Authorize(Roles = "Admin")]
    public class UpdateBookInformationModel : PageModel
    {
        private readonly AppDataContext _db;
        [BindProperty]
        public Books book { get; set; } // access book information within the html part

        public UpdateBookInformationModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet(int Id)
        {
            // this will search for the book with that specfic ID and will then prefil the input fields with the current book info.
            book = _db.Books.Find(Id);
        }

        public void OnPost() {
            _db.Books.Update(book);
            _db.SaveChanges();
            RedirectToPage("/booksread");
        }
    }
}
