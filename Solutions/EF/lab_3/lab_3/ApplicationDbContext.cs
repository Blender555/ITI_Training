using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.SQLConString);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Publisher>()
                .HasMany(p => p.Books)
                .WithOne(b => b.Publisher)
                .HasForeignKey(b => b.Id);

            modelBuilder.Ignore<Library>();

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                      .IsRequired();

                entity.Property(e => e.Email)
                      .HasMaxLength(100);
            });

            modelBuilder.Entity<Product>()
       .Property(p => p.Tax)
       .HasDefaultValue(0.05m);

            modelBuilder.Entity<Product>()
                .Property(p => p.TotalPrice)
                .HasComputedColumnSql("[Price] + [Tax]");

            modelBuilder.Entity<Order>()
        .HasIndex(o => o.OrderDate);

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.CustomerId);

            modelBuilder.Entity<Order>()
       .HasIndex(o => o.OrderDate);

            modelBuilder.HasSequence<int>("InvoiceNumbers", schema: "shared")
       .StartsAt(1000)
       .IncrementsBy(1);

            modelBuilder.Entity<Invoice>()
                .Property(i => i.InvoiceNumber)
                .HasDefaultValueSql("NEXT VALUE FOR shared.InvoiceNumbers");
        }
    }
}
