using Bookclub.Migrations;
using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class NonfictioncshtmlModel : PageModel
    {
        private readonly AppDataContext _db;
        [BindProperty]
        public string user_searches_for { get; set; }
        public NonfictioncshtmlModel(AppDataContext db)
        {
            _db = db;
        }

        // this will retrieve the list of books in that specified selection.
        public IEnumerable<Books> book { get; set; }
        public void OnGet()
        {
            //from the images folder, it will only select books which start with NF.
            book = _db.Books.Where(p => p.BookImage.StartsWith("NF"));
        }
        public IActionResult OnGetBook(int Id)
        {
            var findItem = _db.Books.Find(Id);
            _db.Books.Remove(findItem);
            _db.SaveChanges();
            return RedirectToPage("/Nonfictioncshtml");
        }

        public void OnPost()
        {
            // this will return what the user has searched for.
            book = _db.Books.Where(x => x.BookName.Contains(user_searches_for));
        }
    }
}
