using MediatR;

namespace FadakTest.AppService.Book.GetAll
{
    public class GetAllBookRequest : BaseRequest,IRequest<GetAllBookResponse>
    {
    }
}
