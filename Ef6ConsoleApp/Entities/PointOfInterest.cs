﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ef6ConsoleApp.Entities;

public class PointOfInterest
{
    public PointOfInterest(string name)
    {
        Name = name;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    
    [MaxLength(200)]
    public string Description { get; set; }
    
    [ForeignKey("CityId")]
    public City? City { get; set; }
    public int CityId { get; set; }
    
}