using AutoMapper;
using FadakTest.Domain.Models;
using FadakTest.DTO;

namespace FadakTest.Mappers
{
    public class FadakTestMappingProfile : Profile
    {
        public FadakTestMappingProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();


        }
    }
}
