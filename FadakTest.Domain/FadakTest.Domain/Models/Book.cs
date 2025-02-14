namespace FadakTest.Domain.Models
{
    public class Book : Resource
    {
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        
        public Guid? AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
