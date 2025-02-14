namespace FadakTest.AppService.Author.Update
{
    public class UpdateAuthorRequest : BaseRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
