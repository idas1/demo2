using Ecommerce.API.Data;
using Ecommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                .OrderByDescending(p => p.CreatedDate)
                .ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId, string? sortBy = null)
        {
            var query = _context.Products
                .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                .Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId));

            query = sortBy?.ToLower() switch
            {
                "price_asc" => query.OrderBy(p => p.SalePrice ?? p.OriginalPrice),
                "price_desc" => query.OrderByDescending(p => p.SalePrice ?? p.OriginalPrice),
                _ => query.OrderByDescending(p => p.CreatedDate)
            };

            return await query.ToListAsync();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateProductCategoriesAsync(int productId, List<int> categoryIds)
        {
            var existing = await _context.ProductCategories
                .Where(pc => pc.ProductId == productId)
                .ToListAsync();
            _context.ProductCategories.RemoveRange(existing);

            var newMappings = categoryIds.Select(cId => new ProductCategory
            {
                ProductId = productId,
                CategoryId = cId
            });
            _context.ProductCategories.AddRange(newMappings);
            await _context.SaveChangesAsync();
        }
    }
}
