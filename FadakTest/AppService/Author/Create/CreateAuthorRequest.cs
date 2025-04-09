using MediatR;

namespace FadakTest.AppService.Author.Create
{
    public class CreateAuthorRequest : BaseRequest, IRequest<CreateAuthorResponse>
    {
        public string Name { get; set; }
    }
}
