﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPrzykladowe.Models;

[Table("Product")]
public class Product
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10,2)]
    public double Price { get; set; }

    public ICollection<ProductOrder> ProductOrders { get; set; } = null!;
}