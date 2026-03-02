using Ecommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-Many: Product <-> Category
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

            // Product config
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.OriginalPrice).HasColumnType("decimal(18,2)");
                entity.Property(p => p.SalePrice).HasColumnType("decimal(18,2)");
                entity.Property(p => p.CreatedDate).HasDefaultValueSql("GETDATE()");
            });

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Điện thoại" },
                new Category { Id = 2, Name = "Laptop" },
                new Category { Id = 3, Name = "Phụ kiện" },
                new Category { Id = 4, Name = "Tablet" },
                new Category { Id = 5, Name = "Đồng hồ thông minh" }
            );

            // Seed Products
            var random = new Random(42);
            var products = new List<Product>();
            var productNames = new[]
            {
                "iPhone 15 Pro Max", "Samsung Galaxy S24 Ultra", "Xiaomi 14 Pro",
                "MacBook Air M3", "Dell XPS 15", "Asus Zenbook 14",
                "AirPods Pro 2", "Samsung Galaxy Buds 3", "Logitech MX Master 3S",
                "iPad Pro M4", "Samsung Galaxy Tab S9", "Xiaomi Pad 6",
                "Apple Watch Series 9", "Samsung Galaxy Watch 6", "Garmin Venu 3",
                "Sony WH-1000XM5", "Anker PowerBank 20K", "Baseus USB-C Hub",
                "OPPO Find X7 Ultra", "Google Pixel 8 Pro"
            };

            for (int i = 0; i < 20; i++)
            {
                var price = Math.Round((decimal)(random.Next(500, 5000) * 10000), 2);
                products.Add(new Product
                {
                    Id = i + 1,
                    Name = productNames[i],
                    OriginalPrice = price,
                    SalePrice = random.Next(0, 2) == 1 ? Math.Round(price * 0.85m, 2) : null,
                    Content = $"Mô tả chi tiết sản phẩm {productNames[i]}. Sản phẩm chất lượng cao, bảo hành chính hãng.",
                    CreatedDate = DateTime.Now
                });
            }
            modelBuilder.Entity<Product>().HasData(products);

            // Seed ProductCategories
            var productCategories = new List<ProductCategory>
            {
                // Phones
                new() { ProductId = 1, CategoryId = 1 }, new() { ProductId = 2, CategoryId = 1 },
                new() { ProductId = 3, CategoryId = 1 }, new() { ProductId = 19, CategoryId = 1 },
                new() { ProductId = 20, CategoryId = 1 },
                // Laptops
                new() { ProductId = 4, CategoryId = 2 }, new() { ProductId = 5, CategoryId = 2 },
                new() { ProductId = 6, CategoryId = 2 },
                // Accessories
                new() { ProductId = 7, CategoryId = 3 }, new() { ProductId = 8, CategoryId = 3 },
                new() { ProductId = 9, CategoryId = 3 }, new() { ProductId = 16, CategoryId = 3 },
                new() { ProductId = 17, CategoryId = 3 }, new() { ProductId = 18, CategoryId = 3 },
                // Tablets
                new() { ProductId = 10, CategoryId = 4 }, new() { ProductId = 11, CategoryId = 4 },
                new() { ProductId = 12, CategoryId = 4 },
                // Smartwatches
                new() { ProductId = 13, CategoryId = 5 }, new() { ProductId = 14, CategoryId = 5 },
                new() { ProductId = 15, CategoryId = 5 },
                // Cross-category (Many-to-Many)
                new() { ProductId = 7, CategoryId = 1 },  // AirPods -> Phone accessory
                new() { ProductId = 8, CategoryId = 1 },  // Galaxy Buds -> Phone accessory
                new() { ProductId = 13, CategoryId = 1 }, // Apple Watch -> Phone accessory
                new() { ProductId = 14, CategoryId = 1 }, // Galaxy Watch -> Phone accessory
            };
            modelBuilder.Entity<ProductCategory>().HasData(productCategories);
        }
    }
}
