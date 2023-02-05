using BuberBreakfast.Models;
using BuberBreakfast.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BuberBreakfast.Persistence;

public class BuberBreakfastDbContext : DbContext
{
    public BuberBreakfastDbContext(DbContextOptions<BuberBreakfastDbContext> options) : base(options)
    {
    }

    // This is a set/list of breakfasts
    public DbSet<Breakfast> Breakfasts { get; set; } = null!;

    // EF will use this information to map to the DB Layer for migrations/operations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BreakfastConfigurations());
    }
}