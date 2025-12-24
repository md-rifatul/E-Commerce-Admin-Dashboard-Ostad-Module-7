using System.Xml.Linq;
using E_Commerce_Admin_Dashboard.Models;

namespace E_Commerce_Admin_Dashboard.Data
{
    public static class ProductStore
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "Gaming Laptop",
                Price = 85000,
                StockQuantity = 5
            },
            new Product
            {
                Id = 2,
                Name = "Headphone",
                Description = "Wireless Headphone",
                Price = 3500,
                StockQuantity = 20
            }
        };
    }
}
