using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public int Age { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
