using FadakTest.AppService.Book.Create;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;

namespace FadakTest.AppService.Author.GetAll
{
    public class GetAllAuthorRequestHandler
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;
        public GetAllAuthorRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<GetAllAuthorResponse> Handle(GetAllAuthorRequest request)
        {
            using var context = _contextProvider.GetContext().Context;
            var authors = context.Authors.ToList();

            if (authors == null)
                throw new FadakTestException(ErrorCode.DuplicatedName, "برند با این نام وجود دارد.");

            await context.SaveChangesAsync();
            return new GetAllAuthorResponse
            {
                Authors = authors
            };
        }
    }
}
