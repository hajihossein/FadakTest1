using AutoMapper;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;
using MediatR;

namespace FadakTest.AppService.Book.Create
{
    public class CreateBookRequestHandler : IRequestHandler<CreateBookRequest,CreateBookResponse>
    {
        private readonly IFadakTestDbContextProvider _contextProvider;

        public CreateBookRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<CreateBookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;
            if (context.Books.Any(x => x.Name == request.Name))
                throw new FadakTestException(ErrorCode.DuplicatedName, "برند با این نام وجود دارد.");

            var book = new Domain.Models.Book()
            {
                Name = request.Name,
                Title = request.Title,
                PublishedYear = request.PublisherYear,
                AuthorId = request.AuthorId
            };

            book = context.Books.Add(book).Entity;
            await context.SaveChangesAsync();
            return new CreateBookResponse
            {
                Book = book
            };
        }
    }
}
