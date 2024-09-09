

using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Size { get; set; } = string.Empty;
    }
}
