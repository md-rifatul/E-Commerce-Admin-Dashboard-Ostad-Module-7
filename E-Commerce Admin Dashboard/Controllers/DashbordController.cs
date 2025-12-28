using E_Commerce_Admin_Dashboard.Services.IServices;
using E_Commerce_Admin_Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard.Controllers
{
    public class DashbordController : Controller
    {
        private readonly ICategoryService _categoryService;
        public readonly IProductService _productService;
        public DashbordController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index(int categoryPage = 1, int productPage = 1)
        {
            int pageSize = 5;
            var categories = _categoryService.GetAllCategory(categoryPage, pageSize);
            var products = _productService.GetAllProducts(productPage, pageSize);

            var vm = new DashbordPageViewModel
            {
                Categorys = categories,
                Products = products
            };
            return View(vm);
        }
    }
}
