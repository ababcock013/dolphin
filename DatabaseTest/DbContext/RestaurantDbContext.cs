using DatabaseTest.DbSeeds;
using DatabaseTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.DbContext;

public class RestaurantDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    private const string connectionString =
        "User ID=dev;Password=password;Host=localhost;Port=5555;Database=development;";
    
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var orderData = RestaurantSeeds.OrdersSeed();
        var restaurantData = RestaurantSeeds.RestaurantsSeed();
        
        modelBuilder.Entity<Restaurant>().HasData(restaurantData);
        modelBuilder.Entity<Order>().HasData(orderData);
        base.OnModelCreating(modelBuilder);
    }
}