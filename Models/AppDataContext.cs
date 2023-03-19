using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookclub.Models
{
    public class AppDataContext : IdentityDbContext<AppUser>
    {

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<Events> Events { get; set; }



    }
}
