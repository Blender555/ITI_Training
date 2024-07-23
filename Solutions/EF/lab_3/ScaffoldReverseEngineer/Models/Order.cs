using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

[Table("Order")]
[Index("CustomerId", Name = "IX_Order_CustomerId")]
[Index("OrderDate", Name = "IX_Order_OrderDate")]
public partial class Order
{
    [Key]
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer Customer { get; set; } = null!;
}
