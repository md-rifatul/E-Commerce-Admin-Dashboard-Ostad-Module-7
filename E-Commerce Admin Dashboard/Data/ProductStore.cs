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
            },
            new Product
            {
                Id = 3,
                Name = "Keyboard",
                Description = "Mechanical Keyboard",
                Price = 4500,
                StockQuantity = 15
            },
            new Product
            {
                Id = 4,
                Name = "Mouse",
                Description = "Wireless Mouse",
                Price = 1500,
                StockQuantity = 25
            },
            new Product
            {
                Id = 5,
                Name = "Monitor",
                Description = "Full HD Monitor",
                Price = 12000,
                StockQuantity = 10
            },
            new Product
            {
                Id = 6,
                Name = "Printer",
                Description = "Laser Printer",
                Price = 18000,
                StockQuantity = 8
            },
            new Product
            {
                Id = 7,
                Name = "Webcam",
                Description = "HD Webcam",
                Price = 5000,
                StockQuantity = 12
            }
        };
    }
}
