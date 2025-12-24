using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Services.IServices;
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
        public IActionResult Dashboard()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
        [HttpGet]
        public IActionResult Manage()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                _productService.AddProduct(product);
                TempData["Success"] = "Product added successfully!";
                ModelState.Clear();
            }

            return RedirectToAction("Manage");
        }
    }
}
