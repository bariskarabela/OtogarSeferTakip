using Microsoft.EntityFrameworkCore;

namespace OtogarSeferTakip.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
     

    }
}
