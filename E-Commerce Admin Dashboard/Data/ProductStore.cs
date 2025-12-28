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
            // Added products
            new Product
            {
                Id = 3,
                Name = "Smartphone",
                Description = "Android Smartphone with 128GB storage",
                Price = 30000,
                StockQuantity = 15
            },
            new Product
            {
                Id = 4,
                Name = "Smartwatch",
                Description = "Fitness tracking smartwatch",
                Price = 12000,
                StockQuantity = 25
            },
            new Product
            {
                Id = 5,
                Name = "Tablet",
                Description = "10-inch Android tablet",
                Price = 20000,
                StockQuantity = 10
            },
            new Product
            {
                Id = 6,
                Name = "Bluetooth Speaker",
                Description = "Portable Bluetooth speaker",
                Price = 4500,
                StockQuantity = 30
            },
            new Product
            {
                Id = 7,
                Name = "Keyboard",
                Description = "Mechanical keyboard",
                Price = 5500,
                StockQuantity = 18
            },
            new Product
            {
                Id = 8,
                Name = "Mouse",
                Description = "Wireless optical mouse",
                Price = 1500,
                StockQuantity = 40
            },
            new Product
            {
                Id = 9,
                Name = "Monitor",
                Description = "24-inch Full HD monitor",
                Price = 18000,
                StockQuantity = 12
            },
            new Product
            {
                Id = 10,
                Name = "External Hard Drive",
                Description = "1TB USB 3.0 external hard drive",
                Price = 6500,
                StockQuantity = 22
            },
            new Product
            {
                Id = 11,
                Name = "Power Bank",
                Description = "10000mAh portable charger",
                Price = 2200,
                StockQuantity = 35
            },
            new Product
            {
                Id = 12,
                Name = "Camera",
                Description = "DSLR camera with 18-55mm lens",
                Price = 55000,
                StockQuantity = 8
            }
        };
    }
}