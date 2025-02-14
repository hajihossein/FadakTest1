using System.Reflection.Metadata.Ecma335;

namespace FadakTest.DTO
{
    public class BookDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }

        public Guid? AuthorId { get; set; }
    }
}
