using AutoMapper;
using Dealing_with_AutoMapper.DTOs;
using Dealing_with_AutoMapper.Models;

namespace Dealing_with_AutoMapper.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dist => dist.BookID, src => src.MapFrom(src => src.ID))
                .ForMember(dist => dist.IsFree, src => src.MapFrom(src => src.Price == 0))
                .ReverseMap();

        }
    }
}
