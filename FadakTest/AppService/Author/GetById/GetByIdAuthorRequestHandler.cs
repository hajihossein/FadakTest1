using FadakTest.AppService.Book.Create;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;
using MediatR;

namespace FadakTest.AppService.Author.GetById
{
    public class GetByIdAuthorRequestHandler : IRequestHandler<GetByIdAuthorRequest, GetByIdAuthorResponse>
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;

        public GetByIdAuthorRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        //public async Task<GetByIdAuthorResponse> Handle(GetByIdAuthorRequest request)
        //{
        //    using var context = _contextProvider.GetContext().Context;

        //    var author = context.Authors.FirstOrDefault(x => x.Id == request.Id);

        //    if (context.Authors.Any(x => x.Id == request.Id))
        //        throw new FadakTestException(ErrorCode.DuplicatedName, "نویسنده با این نام وجود دارد.");

        //    return new GetByIdAuthorResponse
        //    {
        //        Author = author
        //    };
        //}

        public async Task<GetByIdAuthorResponse> Handle(GetByIdAuthorRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;

            var author = context.Authors.FirstOrDefault(x => x.Id == request.Id);

            if (context.Authors.Any(x => x.Id == request.Id))
                throw new FadakTestException(ErrorCode.DuplicatedName, "نویسنده با این نام وجود دارد.");

            return new GetByIdAuthorResponse
            {
                Author = author
            };
        }
    }
}
