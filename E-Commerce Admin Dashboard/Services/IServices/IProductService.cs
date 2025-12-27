using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Services.IServices
{
    public interface IProductService
    {
        List<ProductViewModel> GetAllProducts();
        void AddProduct(Product product);
    }
}
