using CountryClubAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryClubAPI.DataAccess
{
    public class CountryClubContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public CountryClubContext(DbContextOptions<CountryClubContext> options) : base(options)
        {
            
        }
    }
}
