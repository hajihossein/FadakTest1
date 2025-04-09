using MediatR;

namespace FadakTest.AppService.Book.GetById
{
    public class GetByIdBookRequest : BaseRequest, IRequest<GetByIdBookResponse>
    {
        public Guid Id { get; set; }
    }
}
