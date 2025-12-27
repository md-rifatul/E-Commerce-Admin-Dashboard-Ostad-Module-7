using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Admin_Dashboard.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Stock must be non-negative")]
        public int StockQuantity { get; set; }
    }
}
