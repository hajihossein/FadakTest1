using AutoMapper;
using FadakTest.AppService.Author.Create;
using FadakTest.Domain.Models;
using FadakTest.DTO;
using FadakTest.Messages.Author;

namespace FadakTest.Mappers
{
    public class FadakTestMappingProfile : Profile
    {
        public FadakTestMappingProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();

            CreateMap<FadakTest.Messages.Author.CreateAuthorRequest, FadakTest.AppService.Author.Create.CreateAuthorRequest>();
            CreateMap<FadakTest.Messages.Author.GetAllAuthorRequest, FadakTest.AppService.Author.GetAll.GetAllAuthorRequest>();
            CreateMap<FadakTest.Messages.Author.GetAuthorsBooksRequest, FadakTest.AppService.Author.GetAuthorsBooks.GetAuthorsBooksRequest>();
            CreateMap<FadakTest.Messages.Author.GetByIdAuthorRequest, FadakTest.AppService.Author.GetById.GetByIdAuthorRequest>();
            CreateMap<FadakTest.Messages.Author.UpdateAuthorRequest, FadakTest.AppService.Author.Update.UpdateAuthorRequest>();

            CreateMap<FadakTest.Messages.Book.CreateBookRequest, FadakTest.AppService.Book.Create.CreateBookRequest>();
            CreateMap<FadakTest.Messages.Book.GetAllBookRequest, FadakTest.AppService.Book.GetAll.GetAllBookRequest>();
            CreateMap<FadakTest.Messages.Book.GetByIdBookRequest, FadakTest.AppService.Book.GetById.GetByIdBookRequest>();
            CreateMap<FadakTest.Messages.Book.UpdateBookRequest, FadakTest.AppService.Book.Update.UpdateBookRequest>();



            CreateMap<FadakTest.Messages.Author.CreateAuthorResponse, FadakTest.AppService.Author.Create.CreateAuthorResponse>();
            CreateMap<FadakTest.Messages.Author.GetAllAuthorResponse, FadakTest.AppService.Author.GetAll.GetAllAuthorResponse>();
            CreateMap<FadakTest.Messages.Author.GetAuthorsBooksResponse, FadakTest.AppService.Author.GetAuthorsBooks.GetAuthorsBooksResponse>();
            CreateMap<FadakTest.Messages.Author.GetByIdAuthorResponse, FadakTest.AppService.Author.GetById.GetByIdAuthorResponse>();
            CreateMap<FadakTest.Messages.Author.UpdateAuthorResponse, FadakTest.AppService.Author.Update.UpdateAuthorResponse>();

            CreateMap<FadakTest.Messages.Book.CreateBookResponse, FadakTest.AppService.Book.Create.CreateBookResponse>();
            CreateMap<FadakTest.Messages.Book.GetAllBookResponse, FadakTest.AppService.Book.GetAll.GetAllBookResponse>();
            CreateMap<FadakTest.Messages.Book.GetByIdBookResponse, FadakTest.AppService.Book.GetById.GetByIdBookResponse>();
            CreateMap<FadakTest.Messages.Book.UpdateBookResponse, FadakTest.AppService.Book.Update.UpdateBookResponse>();
        }
    }
}
