using Microsoft.EntityFrameworkCore;

namespace Bookclub.Models
{
    [PrimaryKey(nameof(BooksID))]
    public class Books
    {
        public int BooksID;

        public string BookName { get; set; }

        public string BooksDescription { get; set; }

        public string BookImage { get; set; }

        public string imageAltDesc { get; set; }
        public string pageRef { get; set; }
    }
}
