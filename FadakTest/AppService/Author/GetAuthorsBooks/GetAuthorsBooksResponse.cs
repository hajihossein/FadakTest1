namespace FadakTest.AppService.Author.GetAuthorsBooks
{
    public class GetAuthorsBooksResponse
    {
        public IEnumerable<FadakTest.Domain.Models.Book> Books { get; set; }
    }
}
