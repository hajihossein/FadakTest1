using MediatR;

namespace FadakTest.AppService.Author.GetById
{
    public class GetByIdAuthorRequest : BaseRequest, IRequest<GetByIdAuthorResponse>
    {
        public Guid Id { get; set; }
    }
}
