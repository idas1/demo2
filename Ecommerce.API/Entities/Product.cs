using System.ComponentModel.DataAnnotations;

namespace Ecommerce.API.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? ImagePath { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal OriginalPrice { get; set; }

        public decimal? SalePrice { get; set; }

        public string? Content { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
