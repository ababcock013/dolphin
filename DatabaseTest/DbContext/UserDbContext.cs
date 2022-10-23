using DatabaseTest.DbSeeds;
using DatabaseTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.DbContext;

public class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<User> Users { get; set; }

    private const string connectionString =
        "User ID=dev;Password=password;Host=localhost;Port=5555;Database=development;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var userData = UserSeed.seedUsers();
        modelBuilder.Entity<User>().HasData(userData);
        base.OnModelCreating(modelBuilder);
    }
}