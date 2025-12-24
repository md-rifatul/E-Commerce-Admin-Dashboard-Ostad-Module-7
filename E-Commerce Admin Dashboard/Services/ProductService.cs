using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Services.IServices;

namespace E_Commerce_Admin_Dashboard.Services
{
    public class ProductService : IProductService
    {
        public void AddProduct(Product product)
        {
            product.Id = ProductStore.Products.Count + 1;
            ProductStore.Products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return ProductStore.Products;
        }
    }
}
