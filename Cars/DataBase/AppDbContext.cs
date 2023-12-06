using Cars.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cars.DataBase;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Owner> Owners { get; set; }
}