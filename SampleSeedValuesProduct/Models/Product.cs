using System.ComponentModel.DataAnnotations;

namespace SampleSeedValuesProduct.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
    }
}
