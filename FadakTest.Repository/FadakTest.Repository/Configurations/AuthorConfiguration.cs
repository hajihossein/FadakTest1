using FadakTest.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FadakTest.Repository.Configurations
{
    internal class AuthorConfiguration : ResourceConfiguration<Author>
    {
        public override void ConfigureDerived(EntityTypeBuilder<Author> builder)
        {
            builder.HasMany(c => c.Books)
                   .WithOne(u => u.Author)
                   .HasForeignKey(u => u.Id);
        }
    }
}
