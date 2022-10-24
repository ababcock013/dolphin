// See https://aka.ms/new-console-template for more information

using DatabaseTest.DbContext;
using DatabaseTest.Entities;

Console.WriteLine("Hello, World!");

using (var context = new RestaurantDbContext())
{
    var rests = context.Restaurants.Find(1).ToString();

    Console.WriteLine(rests);
}