using ICanDoIt.Data.Configurations;
using ICanDoIt.Data.Seeds;
using ICanDoIt.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICanDoIt.Data
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem>  OrderItems { get; set; }
        public DbSet<Adresses> Adresses { get; set; }
        public DbSet<cargoStatus> cargoStatuses { get; set; }
        public DbSet<ProductImages> productImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CargoConfiguration());

            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CargoSeed(new int[] { 1, 2, 3 }));
        }
    }
}
