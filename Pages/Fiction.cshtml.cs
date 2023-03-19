using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class FictionModel : PageModel
    {

        private readonly AppDataContext _db;


        [BindProperty]
        public string user_searches_for { get; set; }

        public FictionModel(AppDataContext db)
        {
            _db = db;
        }


        public IEnumerable<Books> book { get; set; }
        public void OnGet()
        {
            // images have a unqiue naming convention determining which page they need to be displayed on.
            book = _db.Books.Where(p => p.BookImage.StartsWith("FI_"));
        }

        public IActionResult OnGetBook(int Id)
        {
            var findItem = _db.Books.Find(Id);
            _db.Books.Remove(findItem);
            _db.SaveChanges();
            return RedirectToPage("/Fiction");
        }



        public void OnPost() 
        {
            // this will return what the user has searched for.
            book = _db.Books.Where(x => x.BookName.Contains(user_searches_for));
        }
    }
}
