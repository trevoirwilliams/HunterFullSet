using AutoMapper;
using Hunter.API.Data;
using Hunter.API.DTOs;

namespace Hunter.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<BookReadOnlyDto, Book>().ReverseMap();

            CreateMap<ApiUser, UserDto>().ReverseMap();
        }
    }
}
