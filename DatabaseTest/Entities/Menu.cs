using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTest.Entities;

public class Menu
{
    public Menu(string menuName)
    {
        MenuName = menuName;
    }

    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string MenuName { get; set; }

    public string Category { get; set; }// Main dishes, sides, drinks, deserts 

    public ICollection<Item> Items { get; set; } = new List<Item>();

    
    [ForeignKey("RestaurantId")]
    public Restaurant? Restaurant { get; set; }
    public int RestaurantId { get; set; }

}