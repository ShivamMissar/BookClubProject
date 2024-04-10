using Bookclub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Bookclub.Pages
{
    [Authorize(Roles = "Admin")]
    public class ManageBooks : PageModel
    {
        //need to access the Books table.
        private readonly AppDataContext _db;
        
        public ManageBooks(AppDataContext db)
        {
            _db = db;
        }

      
        
        [BindProperty]
        public Books book { get; set; }

        [BindProperty]
        public bool url { get; set; }
        public bool save { get; set; }

        public string button { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public void OnGet()
        {
            url = Request.QueryString.HasValue;
            book = _db.Books.Find(Id);
        }

       
        public IActionResult OnPost()
        {
            _db.Books.Add(book);
            _db.SaveChanges(true);
            return RedirectToPage("/booksread");
        }
        public IActionResult OnPostUpdate(int ID)
        {
        

             var _book = _db.Books.Find(ID);
            _book.BookName = book.BookName;
            _book.BookImage = book.BookImage;
            _book.imageAltDesc = book.imageAltDesc;
            _book.BooksDescription = book.BooksDescription;
            _book.pageRef = book.pageRef;
            _db.Books.Update(_book);
            _db.SaveChanges();
            return RedirectToPage("/booksread");
        }
    }
}
