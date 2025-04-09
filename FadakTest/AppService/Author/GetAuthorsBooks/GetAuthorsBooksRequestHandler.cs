using FadakTest.AppService.Book.Update;
using FadakTest.Domain.Exceptions;
using FadakTest.Domain.Models;
using FadakTest.Repository;
using MediatR;

namespace FadakTest.AppService.Author.GetAuthorsBooks
{
    public class GetAuthorsBooksRequestHandler :IRequestHandler<GetAuthorsBooksRequest,GetAuthorsBooksResponse>
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;
        public GetAuthorsBooksRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<GetAuthorsBooksResponse> Handle(GetAuthorsBooksRequest request)
        {
            using var context = _contextProvider.GetContext().Context;

            var books = context.Books.Where(b => b.AuthorId == request.Id).ToList();

            if (books == null)
                throw new FadakTestException(ErrorCode.DuplicatedName, "این نویسنده هیچ کتابی ندارد.");


            return new GetAuthorsBooksResponse
            {
                Books = books
            };
        }

        public async Task<GetAuthorsBooksResponse> Handle(GetAuthorsBooksRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;

            var books = context.Books.Where(b => b.AuthorId == request.Id).ToList();

            if (books == null)
                throw new FadakTestException(ErrorCode.DuplicatedName, "این نویسنده هیچ کتابی ندارد.");


            return new GetAuthorsBooksResponse
            {
                Books = books
            };
        }
    }
}
