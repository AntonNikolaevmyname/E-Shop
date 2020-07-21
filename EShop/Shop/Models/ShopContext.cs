using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Model
{
    public class ShopContext : DbContext
    {
        // Каждый DbSet соотносится с отдельной таблицей в бд.
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }


        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            // Создание бд, если ее нет.
            Database.EnsureCreated();
        }
    }
}
