namespace FadakTest.Messages.Book
{
    public class UpdateBookRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }

        public Guid? AuthorId { get; set; }
    }
}
