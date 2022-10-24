using DatabaseTest.DbSeeds;
using DatabaseTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.DbContext;

public class RestaurantDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    private const string connectionString =
        "User ID=dev;Password=password;Host=localhost;Port=5555;Database=development; Include Error Detail=true";
    
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
        var menuData = RestaurantSeeds.MenuSeed();
        var itemData = RestaurantSeeds.ItemSeed();

        modelBuilder.Entity<Item>().HasData(itemData);
        modelBuilder.Entity<Menu>().HasData(menuData);
        modelBuilder.Entity<Order>().HasData(orderData);
        modelBuilder.Entity<Restaurant>().HasOne(m => m.Menu)
            .WithOne(i => i.Restaurant)
            .HasForeignKey<Menu>(b => b.RestaurantId);
        modelBuilder.Entity<Restaurant>().HasData(restaurantData);
        base.OnModelCreating(modelBuilder);
    }
}