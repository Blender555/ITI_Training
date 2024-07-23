using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

public partial class Publisher
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual Book? Book { get; set; }
}
