using AutoMapper;
using E_Commerce_Admin_Dashboard.Data;
using E_Commerce_Admin_Dashboard.Pagination;
using E_Commerce_Admin_Dashboard.Services.IServices;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public PageResult<CategoryViewModel> GetAllCategory(int page, int pageSize)
        {
            var categories = CategoryStore.categories;
            var totalItems = categories.Count;

            var pagedCategories = categories
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PageResult<CategoryViewModel>
            {
                Items = _mapper.Map<List<CategoryViewModel>>(pagedCategories),
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems

            };
        }
    }
}
