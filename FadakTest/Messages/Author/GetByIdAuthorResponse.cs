using FadakTest.DTO;

namespace FadakTest.Messages.Author
{
    public class GetByIdAuthorResponse
    {
        public string Name { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
