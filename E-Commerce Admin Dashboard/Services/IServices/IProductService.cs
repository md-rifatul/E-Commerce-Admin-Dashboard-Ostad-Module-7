using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Pagination;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Services.IServices
{
    public interface IProductService
    {
        PageResult<ProductViewModel> GetAllProducts(int page, int pageSize);
        void AddProduct(ProductViewModel productViewModel);
    }
}
