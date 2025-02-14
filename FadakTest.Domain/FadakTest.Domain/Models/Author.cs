namespace FadakTest.Domain.Models
{
    public class Author : Resource
    {
        public ICollection<Book> Books { get; set; }
    }
}
