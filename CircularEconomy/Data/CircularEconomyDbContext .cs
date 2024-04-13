using Microsoft.EntityFrameworkCore;

namespace CircularEconomy.Data;

public class CircularEconomyDbContext : DbContext
{
    public CircularEconomyDbContext(DbContextOptions<CircularEconomyDbContext> options) : base(options)
    {
    }

    public DbSet<Event> Event { get; set; }
}