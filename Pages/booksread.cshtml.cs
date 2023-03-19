using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class TimelineModel : PageModel
    {
        private readonly AppDataContext _db;

        public TimelineModel(AppDataContext db)
        {
            _db = db;
        }
        public IEnumerable<Books> book { get; set; }
        
        public void OnGet()
        {
            book = _db.Books.Where(p => p.BookImage.StartsWith("F"));
        }
    }
}
