using MediatR;

namespace FadakTest.AppService.Book.Update
{
    public class UpdateBookRequest : BaseRequest, IRequest<UpdateBookResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int PublisherYear { get; set; }
        public Guid AuthorId { get; set; }
    }
}
