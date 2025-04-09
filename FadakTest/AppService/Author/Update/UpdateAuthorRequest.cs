using MediatR;

namespace FadakTest.AppService.Author.Update
{
    public class UpdateAuthorRequest : BaseRequest, IRequest<UpdateAuthorResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
