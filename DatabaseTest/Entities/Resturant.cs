using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTest.Entities;

public class Restaurant
{
    public Restaurant(string name)
    {
        Name = name;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    public string Bio { get; set; }

    public Menu Menu { get; set; } // One to one

    public List<Order> Orders { get; set; }
    //Order - one to many
    //Customers - many customers, user_ids

    public string ToString()
    {
        return $"Name: {Name}" +
               $"Orders: {} ";
    }
}