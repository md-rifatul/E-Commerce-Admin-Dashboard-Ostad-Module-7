using E_Commerce_Admin_Dashboard.Models;

namespace E_Commerce_Admin_Dashboard.Services.IServices
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
    }
}
