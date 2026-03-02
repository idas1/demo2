using Ecommerce.API.DTOs;
using Ecommerce.API.Entities;
using Ecommerce.API.Repositories;

namespace Ecommerce.API.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryService(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepo.GetAllAsync();
            return categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name });
        }

        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _categoryRepo.GetByIdAsync(id);
            return category == null ? null : new CategoryDto { Id = category.Id, Name = category.Name };
        }

        public async Task<CategoryDto> CreateAsync(CreateCategoryDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Category name is required");

            var category = new Category { Name = dto.Name };
            var created = await _categoryRepo.CreateAsync(category);
            return new CategoryDto { Id = created.Id, Name = created.Name };
        }

        public async Task<CategoryDto?> UpdateAsync(int id, CreateCategoryDto dto)
        {
            var category = await _categoryRepo.GetByIdAsync(id);
            if (category == null) return null;

            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Category name is required");

            category.Name = dto.Name;
            await _categoryRepo.UpdateAsync(category);
            return new CategoryDto { Id = category.Id, Name = category.Name };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _categoryRepo.GetByIdAsync(id);
            if (category == null) return false;
            await _categoryRepo.DeleteAsync(id);
            return true;
        }
    }
}
