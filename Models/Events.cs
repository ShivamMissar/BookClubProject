using Microsoft.EntityFrameworkCore;

namespace Bookclub.Models
{
    [PrimaryKey(nameof(EventsId))]
    public class Events
    {
       
            public int EventsId;

            public DateTime Date { get; set; }

            public string NameOfEvent { get; set; }

            public string BriefDescription { get; set; }
        }
}
