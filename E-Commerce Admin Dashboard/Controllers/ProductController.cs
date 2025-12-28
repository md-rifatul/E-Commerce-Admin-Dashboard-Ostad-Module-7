using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Services.IServices;
using E_Commerce_Admin_Dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Admin_Dashboard.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Dashboard(int page = 1)
        {
            int pageSize = 5;
            var products = _productService.GetAllProducts(page,pageSize);
            return View(products);
        }
        [HttpGet]
        public IActionResult Manage(int page = 1)
        {
            int pageSize = 5;
            var products = _productService.GetAllProducts(page, pageSize);
            var vm = new ManagePageViewModel
            {
                Products = products,
                NewProduct = new ProductViewModel()
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddProduct(ManagePageViewModel managePageViewModel)
        {
            if(ModelState.IsValid)
            {
                
                _productService.AddProduct(managePageViewModel.NewProduct);
                TempData["Success"] = "Product added successfully!";
                return RedirectToAction("Manage");
            }

            //managePageViewModel.Products = _productService.GetAllProducts();
            return View("Manage", managePageViewModel);
        }
    }
}
