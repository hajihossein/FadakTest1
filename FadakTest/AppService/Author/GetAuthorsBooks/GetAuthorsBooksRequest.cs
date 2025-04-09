using MediatR;

namespace FadakTest.AppService.Author.GetAuthorsBooks
{
    public class GetAuthorsBooksRequest : BaseRequest, IRequest<GetAuthorsBooksResponse>
    {
        public Guid Id { get; set; }
    }
}
