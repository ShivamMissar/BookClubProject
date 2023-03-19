using Microsoft.EntityFrameworkCore;

namespace Bookclub.Models
{
    [PrimaryKey(nameof(ReviewsId))]
    public class Reviews
    {
  
        public int ReviewsId { get; set; }

        public string bookName { get; set; }
        public string optionalName { get; set; } // based on the users choice they can have this as null or as a name.
        public string message { get; set; }
    }
}
