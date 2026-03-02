using Ecommerce.API.DTOs;
using Ecommerce.API.Entities;
using Ecommerce.API.Repositories;

namespace Ecommerce.API.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepo;
        private readonly IWebHostEnvironment _env;

        public ProductService(IProductRepository productRepo, IWebHostEnvironment env)
        {
            _productRepo = productRepo;
            _env = env;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _productRepo.GetAllAsync();
            return products.Select(MapToDto);
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            return product == null ? null : MapToDto(product);
        }

        public async Task<IEnumerable<ProductDto>> GetByCategoryAsync(int categoryId, string? sortBy)
        {
            var products = await _productRepo.GetByCategoryAsync(categoryId, sortBy);
            return products.Select(MapToDto);
        }

        public async Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            if (dto.OriginalPrice <= 0)
                throw new ArgumentException("Price must be greater than 0");

            var product = new Product
            {
                Name = dto.Name,
                OriginalPrice = dto.OriginalPrice,
                SalePrice = dto.SalePrice,
                Content = dto.Content,
                CreatedDate = DateTime.Now
            };

            if (dto.Image != null)
            {
                product.ImagePath = await SaveImageAsync(dto.Image);
            }

            var created = await _productRepo.CreateAsync(product);

            if (dto.CategoryIds.Any())
            {
                await _productRepo.UpdateProductCategoriesAsync(created.Id, dto.CategoryIds);
            }

            var result = await _productRepo.GetByIdAsync(created.Id);
            return MapToDto(result!);
        }

        public async Task<ProductDto?> UpdateAsync(int id, UpdateProductDto dto)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return null;

            if (dto.OriginalPrice <= 0)
                throw new ArgumentException("Price must be greater than 0");

            product.Name = dto.Name;
            product.OriginalPrice = dto.OriginalPrice;
            product.SalePrice = dto.SalePrice;
            product.Content = dto.Content;

            if (dto.Image != null)
            {
                product.ImagePath = await SaveImageAsync(dto.Image);
            }

            await _productRepo.UpdateAsync(product);
            await _productRepo.UpdateProductCategoriesAsync(id, dto.CategoryIds);

            var result = await _productRepo.GetByIdAsync(id);
            return MapToDto(result!);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return false;
            await _productRepo.DeleteAsync(id);
            return true;
        }

        private async Task<string> SaveImageAsync(IFormFile file)
        {
            var uploadsFolder = Path.Combine(_env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "uploads");
            Directory.CreateDirectory(uploadsFolder);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadsFolder, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);

            return $"/uploads/{fileName}";
        }

        private static ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                ImagePath = product.ImagePath,
                OriginalPrice = product.OriginalPrice,
                SalePrice = product.SalePrice,
                Content = product.Content,
                CreatedDate = product.CreatedDate,
                Categories = product.ProductCategories?.Select(pc => new CategoryDto
                {
                    Id = pc.Category.Id,
                    Name = pc.Category.Name
                }).ToList() ?? new()
            };
        }
    }
}
