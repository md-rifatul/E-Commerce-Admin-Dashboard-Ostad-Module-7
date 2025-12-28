using E_Commerce_Admin_Dashboard.Pagination;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Services.IServices
{
    public interface ICategoryService
    {
        PageResult<CategoryViewModel> GetAllCategory(int page, int pageSize);
    }
}
