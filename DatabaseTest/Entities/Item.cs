using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace DatabaseTest.Entities;

public class Item
{
    public Item(string itemName)
    {
        ItemName = itemName;
    }
    
    //TODO: add quantity, size, options ect for diversity of items
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ItemName { get; set; }

    public string Description { get; set; }
    
    public decimal Price { get; set; }
    
    [ForeignKey("OrderId")]
    public Order Order { get; set; }
    public int OrderId { get; set; }
    
    [ForeignKey("MenuId")]
    public Menu Menu { get; set; }
    public int MenuId { get; set; }
    
}