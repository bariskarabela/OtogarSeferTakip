using Microsoft.EntityFrameworkCore;

namespace OtogarSeferTakip.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Tako> Takos { get; set; }
        public DbSet<DrivingLicence> DrivingLicenses { get; set; }


    }
}
