﻿using System.ComponentModel.DataAnnotations;
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
    
    //Menu - one menu
    public Menu Menu { get; set; }
    //Order - many orders
    //Customers - many customers, user_ids
    
    
}