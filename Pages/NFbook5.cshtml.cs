using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class book5Model : PageModel
    {
        private readonly AppDataContext _db;



        public bool returnMessage { get; set; } = false;
        public book5Model(AppDataContext db)

        {
            _db = db;

        }
        public Books book { get; set; }


        [BindProperty]
        public Reviews customer_said { get; set; }


        public List<Reviews> get_reviews { get; set; } = new List<Reviews>();


        public void OnGet()
        {
            book = _db.Books.Where(p => p.BookImage.Contains("JounreyOfIndia")).FirstOrDefault();
            get_reviews = _db.Reviews.Where(p => p.bookName.Contains("Journey Of India")).ToList();
        }


        public IActionResult OnPostAddReview()
        {
            const string bookType = "Journey Of India";
            customer_said.bookName = bookType;
            _db.Add(customer_said);
            _db.SaveChanges();
            return RedirectToPage("/NFbook5");
        }

        public IActionResult OnGetRemove(int Id)
        {
            var findItem = _db.Reviews.Find(Id);
            _db.Reviews.Remove(findItem);
            _db.SaveChanges();
            return RedirectToPage("/NFbook5");
        }
    }
}

