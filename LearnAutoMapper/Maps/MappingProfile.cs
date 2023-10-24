using AutoMapper;
using LearnAutoMapper.Dtos;
using LearnAutoMapper.Models;

namespace LearnAutoMapper.Maps;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Book, BookDto>()
			.ForMember(dest => dest.BookTitle, src => src.MapFrom(src => src.Title))  //when we have different names
			.ForMember(dest => dest.IsFree, src => src.MapFrom(src => src.Price == 0)) //when need to change values
			.ReverseMap();
	}
}
