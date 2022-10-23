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
    
    //Id
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ItemName { get; set; }

    public string Description { get; set; }
    
    public decimal Price { get; set; }
    //Name
    //Description
    //Price
    
}