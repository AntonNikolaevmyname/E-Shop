using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class ProductContext : DbContext
    {
        // Каждый DbSet соотносится с отдельной таблицей в бд.
        public DbSet<Product> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            // Создание бд, если ее нет.
            Database.EnsureCreated();
        }
    }
}
