using Microsoft.EntityFrameworkCore;
using BlazorApp1.Entities;

namespace BlazorApp1.Context
{
    public class ShowTimeContext : DbContext
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options)
            : base(options)
        { }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Band> Bands { get; set; }
    }
}
