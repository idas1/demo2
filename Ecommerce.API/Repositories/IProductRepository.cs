using Ecommerce.API.Entities;

namespace Ecommerce.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId, string? sortBy = null);
        Task<Product> CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task UpdateProductCategoriesAsync(int productId, List<int> categoryIds);
    }
}
