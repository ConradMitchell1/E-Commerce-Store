using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RazorPageApp.Models;

namespace RazorPageApp.Repositories
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }
        public DbSet<OrderModel> OrderModels { get; set; }
        public DbSet<ShippingAddressModel> ShippingAddresses { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToTable("Product");
            modelBuilder.Entity<CategoryModel>().ToTable("Category");
            modelBuilder.Entity<OrderItemModel>().ToTable("OrderItem");
            modelBuilder.Entity<OrderModel>().ToTable("Order");
            modelBuilder.Entity<ShippingAddressModel>().ToTable("ShippingAddress");

        }
    }
}
