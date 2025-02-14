namespace FadakTest.AppService.Book.Create
{
    public class CreateBookRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Title{ get; set; }
        public int PublisherYear { get; set; }
        public  Guid AuthorId { get; set; }
    }
}
