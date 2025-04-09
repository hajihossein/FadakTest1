using FadakTest.AppService.Book.Create;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;
using MediatR;

namespace FadakTest.AppService.Author.Create
{
    public class CreateAuthorRequestHandler : IRequestHandler<CreateAuthorRequest, CreateAuthorResponse>
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;
        public CreateAuthorRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        //public async Task<CreateAuthorResponse> Handle(CreateAuthorRequest request)
        //{
        //    using var context = _contextProvider.GetContext().Context;
        //    if (context.Authors.Any(x => x.Name == request.Name))
        //        throw new FadakTestException(ErrorCode.DuplicatedName, "نویسنده با این نام وجود دارد.");

        //    var author = new Domain.Models.Author()
        //    {
        //        Name = request.Name
        //    };

        //    author = context.Authors.Add(author).Entity;
        //    await context.SaveChangesAsync();

        //    return new CreateAuthorResponse
        //    {
        //        Author = author
        //    };
        //}

        public async Task<CreateAuthorResponse> Handle(CreateAuthorRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;
            if (context.Authors.Any(x => x.Name == request.Name))
                throw new FadakTestException(ErrorCode.DuplicatedName, "نویسنده با این نام وجود دارد.");

            var author = new Domain.Models.Author()
            {
                Name = request.Name
            };

            author = context.Authors.Add(author).Entity;
            await context.SaveChangesAsync();

            return new CreateAuthorResponse
            {
                Author = author
            };
        }
    }
}
