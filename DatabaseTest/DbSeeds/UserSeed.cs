using DatabaseTest.Entities;

namespace DatabaseTest.DbSeeds;

public static class UserSeed
{
    public static List<User> seedUsers()
    {
        return new List<User>
        {
            new User("Andrew", "Babcock"){Id = 1, Age = 20},
            new User("Dave", "McDonald"){Id = 2, Age = 25},
            new User("Chris", "Smith"){Id = 3, Age = 17},
            new User("Mark", "Lee"){Id = 4, Age = 42},
            new User("Jay", "Oswald"){Id = 5, Age = 35},
            new User("Alice", "Wright"){Id = 6, Age = 71},
            new User("John", "Williams"){Id = 7, Age = 73}
    
        };
    }
}