using AutoMapper;
using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Services.IServices;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public void AddProduct(ProductViewModel productViewModel)
        {
            productViewModel.Id = ProductStore.Products.Count + 1;
            ProductStore.Products.Add(_mapper.Map<Product>(productViewModel));
        }

        public List<ProductViewModel> GetAllProducts()
        {
            var products = ProductStore.Products;
            return _mapper.Map<List<ProductViewModel>>(products);
        }
    }
}
