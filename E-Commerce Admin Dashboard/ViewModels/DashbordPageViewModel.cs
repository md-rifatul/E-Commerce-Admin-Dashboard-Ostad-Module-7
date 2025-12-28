using E_Commerce_Admin_Dashboard.Pagination;

namespace E_Commerce_Admin_Dashboard.ViewModels
{
    public class DashbordPageViewModel
    {
        public PageResult<ProductViewModel> Products { get; set; } = new();
        public PageResult<CategoryViewModel> Categorys { get; set; } = new();
    }
}
