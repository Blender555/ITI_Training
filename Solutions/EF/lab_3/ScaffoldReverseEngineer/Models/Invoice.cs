using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

public partial class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public int InvoiceNumber { get; set; }
}
