using AutoMapper;
using Azure.Core;
using FadakTest.AppService.Book.Create;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;

namespace FadakTest.AppService.Book.GetAll
{
    public class GetAllBookRequestHandler
    {
        private readonly IFadakTestDbContextProvider _contextProvider;
        public GetAllBookRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<GetAllBookResponse> Handle(CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;

            var books = context.Books.ToList();

            if (books == null)
                throw new FadakTestException(ErrorCode.DuplicatedName, "لیست کتاب ها خالی است.");


            return new GetAllBookResponse
            {
                Books = books
            };
        }
    }
}
