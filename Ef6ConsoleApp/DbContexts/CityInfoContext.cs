
using Ef6ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ef6ConsoleApp.DbContexts;

public class CityInfoContext : DbContext
{
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<PointOfInterest> PointOfInterest { get; set; } = null!;
    
    private const string ConnectionString = @"Server=localhost,1433;Database=DevTest;User Id=dev;Password=QWer!@34%^";


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var cityData = DataSeeds.CityData();
        var poiData = DataSeeds.Poi();
        modelBuilder.Entity<City>().HasData(cityData);
        modelBuilder.Entity<PointOfInterest>().HasData(poiData);
        base.OnModelCreating(modelBuilder);
    }
}