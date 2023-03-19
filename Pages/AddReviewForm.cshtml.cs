using Bookclub.Migrations;
using Bookclub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class AddReviewFormModel : PageModel
    {
        private readonly AppDataContext _db;
        public String name { get; set; }
        public String review_made { get; set; }

        public AddReviewFormModel(AppDataContext db)
        {
            _db = db;
        }
        public Reviews customer_said { get; set; } // access book information within the html part

        public void OnGet()
        {
            name = User.Identity.Name.ToString();
        }

        public void OnPost()
        {
           
            customer_said.message = review_made;
            _db.Add(customer_said);
            _db.SaveChanges();
        }
    }
}
