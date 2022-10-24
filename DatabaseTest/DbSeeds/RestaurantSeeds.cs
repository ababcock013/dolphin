using DatabaseTest.Entities;

namespace DatabaseTest.DbSeeds;

public static class RestaurantSeeds
{
    public static List<Restaurant> RestaurantsSeed()
    {
        return new List<Restaurant>()
        {
            new Restaurant("Pizza Slut"){Id = 1, Bio = "We make poison, I mean Pizza!" }

        };
    }

    public static List<Order> OrdersSeed()
    {
        return new List<Order>()
        {
            new Order() { Id = 1, RestaurantId = 1, OrderNumber = "ON-1234" }
        };
    }
}