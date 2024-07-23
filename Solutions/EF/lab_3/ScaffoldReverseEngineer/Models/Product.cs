using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Tax { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TotalPrice { get; set; }
}
