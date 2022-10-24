using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTest.Entities;

public class Order
{
    
    public int Id { get; set; }
    //Row_Id
    public string OrderNumber { get; set; }
    //Order number/code
    //Items
    
    //public int RowId { get; set; }
    
    [ForeignKey("RestaurantId")]
    public Restaurant Restaurant { get; set; }
    public int RestaurantId { get; set; }
}