using FadakTest.AppService.Book.Create;
using FadakTest.AppService.Book.Update;
using FadakTest.Domain.Exceptions;
using FadakTest.Repository;

namespace FadakTest.AppService.Author.Update
{
    public class UpdateAuthorRequestHandler
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;
        public UpdateAuthorRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<UpdateAuthorResponse> Handle(UpdateAuthorRequest request)
        {
            using var context = _contextProvider.GetContext().Context;
            if (context.Authors.Any(x => x.Name == request.Name))
                throw new FadakTestException(ErrorCode.DuplicatedName, "کتابی با این نام وجود دارد.");

            var author = context.Authors.Single(b => b.Id == request.Id);
            author.Name = request.Name;


            await context.SaveChangesAsync();

            return new UpdateAuthorResponse
            {
                Author = author
            };
        }
    }
}
