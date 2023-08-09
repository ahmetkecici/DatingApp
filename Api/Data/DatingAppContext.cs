using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DatingAppContext:DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public DatingAppContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
