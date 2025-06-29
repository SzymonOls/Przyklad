﻿using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumPrzykladowe.Models;

[Table("Order")]
public class Order
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
    
    [ForeignKey(nameof(Client))]
    public int ClientId { get; set; }
    
    [ForeignKey(nameof(Status))]
    public int StatusId { get; set; }

    public Client Client { get; set; } = null!;
    public Status Status { get; set; } = null!;
    
    public ICollection<ProductOrder> ProductOrders { get; set; } = null!;
}