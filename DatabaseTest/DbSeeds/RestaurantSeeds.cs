using DatabaseTest.Entities;

namespace DatabaseTest.DbSeeds;

public static class RestaurantSeeds
{
    public static List<Item> ItemSeed()
    {
        return new List<Item>()
        {
            new Item("Large Pizza")
            {
                Id = 1,
                Description = "Nasty pizza made from stale ass hairs and dog milk cheese",
                Price = 9.99m,
                MenuId = 1,
                OrderId = 1
            },
            new Item("Bread sticks")
            {
                Id = 2,
                Description = "Hard old and not even made out of bread",
                Price = 6.49m,
                MenuId = 1,
                OrderId = 1
            }
        };
    }

    public static List<Menu> MenuSeed()
    {
        return new List<Menu>()
        {
            new Menu("Pizza Slut Menu")
            {
                Id = 1,
                Category = "Pizzas",
                RestaurantId = 1

            }
        };

    }
    
    
    public static List<Restaurant> RestaurantsSeed()
    {
        return new List<Restaurant>()
        {
            new Restaurant("Pizza Slut")
            {
                Id = 1, Bio = "We make poison, I mean Pizza!"
            }

        };
    }

    public static List<Order> OrdersSeed()
    {
        return new List<Order>()
        {
            new Order() { Id = 1, RestaurantId = 1, OrderNumber = "ON-1234", }
        };
    }
}