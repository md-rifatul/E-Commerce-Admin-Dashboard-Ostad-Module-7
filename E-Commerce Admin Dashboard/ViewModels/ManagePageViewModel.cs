using E_Commerce_Admin_Dashboard.Pagination;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce_Admin_Dashboard.ViewModels
{
    public class ManagePageViewModel
    {
        public PageResult<ProductViewModel> Products { get; set; } = new();
        public ProductViewModel NewProduct { get; set; } = new();
    }
}
