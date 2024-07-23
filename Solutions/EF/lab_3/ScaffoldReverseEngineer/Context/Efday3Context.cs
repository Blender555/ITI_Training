using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ScaffoldReverseEngineer.Models;

namespace ScaffoldReverseEngineer.Context;

public partial class Efday3Context : DbContext
{
    public Efday3Context()
    {
    }

    public Efday3Context(DbContextOptions<Efday3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database = EFDAY3;Integrated Security = True;Trusted_Connection = true;TrustServerCertificate = True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.Property(e => e.InvoiceNumber).HasDefaultValueSql("(NEXT VALUE FOR [shared].[InvoiceNumbers])");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Tax).HasDefaultValue(0.05m);
            entity.Property(e => e.TotalPrice).HasComputedColumnSql("([Price]+[Tax])", false);
        });
        modelBuilder.HasSequence<int>("InvoiceNumbers", "shared")
            .StartsAt(1000L)
            .UseCache(null);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
