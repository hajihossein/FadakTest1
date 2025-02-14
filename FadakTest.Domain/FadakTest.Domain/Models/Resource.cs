namespace FadakTest.Domain.Models
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }
    }

    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
