using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldReverseEngineer.Models;

[Index("AuthorId", Name = "IX_Books_AuthorId")]
public partial class Book
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int AuthorId { get; set; }

    public int PublisherId { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Books")]
    public virtual Author Author { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("Book")]
    public virtual Publisher IdNavigation { get; set; } = null!;
}
