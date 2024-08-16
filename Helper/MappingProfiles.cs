using AutoMapper;
using MyPersonalProject.Dto;
using MyPersonalProject.Models;

namespace MyPersonalProject.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}
