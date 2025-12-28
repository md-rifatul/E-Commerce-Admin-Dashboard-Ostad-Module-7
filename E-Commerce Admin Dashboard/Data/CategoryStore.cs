using E_Commerce_Admin_Dashboard.Models;

namespace E_Commerce_Admin_Dashboard.Data
{
    public static class CategoryStore
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category
            {
                Id = 1,
                Name = "Electronics"
            },
            new Category
            {
                Id = 2,
                Name = "Fashion"
            },
            new Category
            {
                Id = 3,
                Name = "Home Appliances"
            },
            new Category
            {
                Id = 4,
                Name = "Books"
            },
            new Category
            {
                Id = 5,
                Name = "Sports & Fitness"
            },
            // Added categories
            new Category
            {
                Id = 6,
                Name = "Toys & Games"
            },
            new Category
            {
                Id = 7,
                Name = "Beauty & Personal Care"
            },
            new Category
            {
                Id = 8,
                Name = "Groceries"
            },
            new Category
            {
                Id = 9,
                Name = "Automotive"
            },
            new Category
            {
                Id = 10,
                Name = "Jewelry & Accessories"
            },
            new Category
            {
                Id = 11,
                Name = "Health & Wellness"
            },
            new Category
            {
                Id = 12,
                Name = "Office Supplies"
            },
            new Category
            {
                Id = 13,
                Name = "Pet Supplies"
            },
            new Category
            {
                Id = 14,
                Name = "Music & Instruments"
            },
            new Category
            {
                Id = 15,
                Name = "Garden & Outdoor"
            }
        };
    }
}