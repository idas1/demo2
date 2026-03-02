namespace Ecommerce.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<CategoryDto> Categories { get; set; } = new();
    }

    public class CreateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal OriginalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public string? Content { get; set; }
        public List<int> CategoryIds { get; set; } = new();
        public IFormFile? Image { get; set; }
    }

    public class UpdateProductDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal OriginalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public string? Content { get; set; }
        public List<int> CategoryIds { get; set; } = new();
        public IFormFile? Image { get; set; }
    }

    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
