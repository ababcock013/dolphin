using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DatabaseTest.Entities;

public class User
{
    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    
    public int Age { get; set; }
}   