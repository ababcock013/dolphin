using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTest.Entities;

public class Order
{
    //TODO: Decide if DB or controller calculates and or stores final price
    
    public int Id { get; set; }
    //Row_Id
    public string OrderNumber { get; set; }
    //Order number/code
    //Items

    public List<Item> Items { get; set; }
    
    //public int RowId { get; set; }
    
    [ForeignKey("RestaurantId")]
    public Restaurant Restaurant { get; set; }
    public int RestaurantId { get; set; }
}