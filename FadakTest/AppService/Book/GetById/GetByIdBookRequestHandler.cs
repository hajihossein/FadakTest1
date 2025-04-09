using AutoMapper;
using FadakTest.AppService.Book.Create;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;
using MediatR;

namespace FadakTest.AppService.Book.GetById
{
    public class GetByIdBookRequestHandler :IRequestHandler<GetByIdBookRequest,GetByIdBookResponse>
    {
        private readonly IFadakTestDbContextProvider _contextProvider;
        public GetByIdBookRequestHandler(IFadakTestDbContextProvider contextProvider, IMapper mapper)
        {
            _contextProvider = contextProvider;
        }

        public async Task<GetByIdBookResponse> Handle(GetByIdBookRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;
            if (context.Books.Any(x => x.Id == request.Id))
                throw new FadakTestException(ErrorCode.DuplicatedName, "این کتاب وجود ندارد.");



            var book = context.Books.Single(b => b.Id == request.Id);
            await context.SaveChangesAsync();
            return new GetByIdBookResponse
            {
                Book = book
            };
        }
    }
}
