using Bookclub.Migrations;
using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class AddEventsModel : PageModel
    {
        [BindProperty]
        public Events addNewEvent { get; set; }


        private readonly AppDataContext _db;

        public AddEventsModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost() {
           

            _db.Events.Add(addNewEvent);
            _db.SaveChanges(true);

            return RedirectToPage("/Index");
        }
    }
}
