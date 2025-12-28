using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Pagination;
using E_Commerce_Admin_Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce_Admin_Dashboard.Services.IServices
{
    public interface IProductService
    {
        PageResult<ProductViewModel> GetAllProducts(int page, int pageSize);
        void AddProduct(ProductViewModel productViewModel);
    }
}
