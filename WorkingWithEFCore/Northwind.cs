using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Packt.CS7
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // to use Microsoft SQL Server, uncomment the following 
            optionsBuilder.UseSqlServer( 
                @"Data Source=(localdb)\mssqllocaldb;" +
                "Initial Catalog=Northwind;" +
                "Integrated Security=true;" +
                "MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // example of using Fluent API instead of attributes
            // to limit the length of a category name to under 40 
            modelBuilder.Entity<Category>()
              .Property(category => category.CategoryName)
              .IsRequired()
              .HasMaxLength(40);

            // global filter to remove discontinued items
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.Discontinued);
        }
        
        
    }
}
