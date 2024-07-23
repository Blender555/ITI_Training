using lab_3;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                var author = new Author 
                { 
                    Name = "Author1", 
                    Books = new List<Book> { new Book { Title = "Book1" }, new Book { Title = "Book2" } } 
                };
                context.Authors.Add(author);
                context.SaveChanges();

                var authorToDelete = context.Authors.Include(a => a.Books).First(a => a.Id == author.Id);
                context.Authors.Remove(authorToDelete);
                context.SaveChanges();

                var books = context.Books.Where(b => b.AuthorId == author.Id).ToList();
                Console.WriteLine(books.Count);

                var customer = new Customer { Name = "Ali", Email = "Ali@gmail.com", Age = 30 };
                context.Customers.Add(customer);
                context.SaveChanges();

                var product = new Product { Price = 100 };
                context.Products.Add(product);
                context.SaveChanges();

                var savedProduct = context.Products.Find(product.ProductId);
                Console.WriteLine(savedProduct.TotalPrice);

                var invoice = new Invoice();
                context.Invoices.Add(invoice);
                context.SaveChanges();

                var savedInvoice = context.Invoices.FirstOrDefault(i => i.InvoiceId == invoice.InvoiceId);
                Console.WriteLine($"Invoice ID: {savedInvoice.InvoiceId}, Invoice Number: {savedInvoice.InvoiceNumber}");
            }

        }
    }
}