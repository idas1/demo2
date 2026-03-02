using System.ComponentModel.DataAnnotations;

namespace Ecommerce.API.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
