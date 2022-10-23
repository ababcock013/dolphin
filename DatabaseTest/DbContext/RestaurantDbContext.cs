using DatabaseTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.DbContext;

public class RestaurantDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    private DbSet<Restaurant> Restaurants { get; set; }
    

}