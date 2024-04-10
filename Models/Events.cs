using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Bookclub.Models
{
    [PrimaryKey(nameof(EventsId))]
    public class Events
    {
       
            public int EventsId;

            public DateTime DateOfEvent { get; set; }

            public string NameOfEvent { get; set; }

            public string BriefDescription { get; set; }
        }
}
