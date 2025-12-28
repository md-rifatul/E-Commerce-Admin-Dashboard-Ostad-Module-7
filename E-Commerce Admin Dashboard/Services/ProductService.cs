using AutoMapper;
using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.Pagination;
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

        public PageResult<ProductViewModel> GetAllProducts(int page, int pageSize)
        {
            var products = ProductStore.Products;
            var totalItems = products.Count;

            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PageResult<ProductViewModel>
            {
                Items = _mapper.Map<List<ProductViewModel>>(pagedProducts),
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems

            };

        }
    }
}
