using AcRepairWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace AcRepairWebsite
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
    }
}

