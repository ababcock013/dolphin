using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Ef6ConsoleApp;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions<UserContext> options) :base(options)
    {
        
    }
}