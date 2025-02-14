using FadakTest.Domain.Exceptions;
using FadakTest.Repository;

namespace FadakTest.AppService.Book.Update
{
    public class UpdateBookRequestHandler
    {
        protected readonly IFadakTestDbContextProvider _contextProvider;
        public UpdateBookRequestHandler(IFadakTestDbContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public async Task<UpdateBookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            using var context = _contextProvider.GetContext().Context;
            if (context.Books.Any(x => x.Name == request.Name))
                throw new FadakTestException(ErrorCode.DuplicatedName, "کتابی با این نام وجود دارد.");

            var book = context.Books.Single(b => b.Id == request.Id);
            book.Name = request.Name;
            book.Title = request.Title;
            book.PublishedYear = request.PublisherYear;
            book.AuthorId = request.AuthorId;


            await context.SaveChangesAsync();

            return new UpdateBookResponse
            {
                Book = book
            };
        }
    }
}
