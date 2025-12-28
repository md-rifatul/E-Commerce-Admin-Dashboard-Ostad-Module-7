using AutoMapper;
using E_Commerce_Admin_Dashboard.Models;
using E_Commerce_Admin_Dashboard.ViewModels;

namespace E_Commerce_Admin_Dashboard.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
