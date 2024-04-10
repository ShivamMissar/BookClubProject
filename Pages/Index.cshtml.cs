using Bookclub.Migrations;
using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDataContext _db;

        public IndexModel(ILogger<IndexModel> logger, AppDataContext db)
        {
            _logger = logger;
            _db = db;
        }

        public DateTime expiredEvent { get; set; }

   

        public List<Events> upcomingEvents { get; set; } = new List<Events>();


  

        public void OnGet()
        {
            upcomingEvents = _db.Events.ToList();
           
        }

        public IActionResult OnGetRemove(int Id)
        {
            var findItem = _db.Events.Find(Id);
            _db.Events.Remove(findItem);
            _db.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}