using FadakTest.DTO;

namespace FadakTest.Messages.Book
{
    public class GetAllBookResponse
    {
        public IEnumerable<BookDto> Books { get; set; }
    }
}