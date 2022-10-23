using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTest.Entities;

public class Menu
{
    public Menu(string menuName)
    {
        MenuName = menuName;
    }
    //Id
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string MenuName { get; set; }

    public ICollection<Item> Items { get; set; } = new List<Item>();
    //Items
    
    [ForeignKey("RestaurantId")]
    public Restaurant? Restaurant { get; set; }

    public int RestaurantId { get; set; }

}