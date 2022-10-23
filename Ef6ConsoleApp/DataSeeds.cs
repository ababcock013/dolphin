using Ef6ConsoleApp.Entities;

namespace Ef6ConsoleApp;

public class DataSeeds
{
    public static List<City> CityData()
    {
        return new List<City>
        {
            new City("New York"){Id = 1, Description = "ghjghksa"},
            new City("Boston"){Id = 2, Description = "dhjskadhsja"}

        };

    }

    public static List<PointOfInterest> Poi()
    {
        return new List<PointOfInterest>
        {
            new PointOfInterest("place") { Id = 1, Description = "over there", CityId = 1 },
            new PointOfInterest("Here") { Id = 2, Description = "Up", CityId = 2 }
        };
    }
}