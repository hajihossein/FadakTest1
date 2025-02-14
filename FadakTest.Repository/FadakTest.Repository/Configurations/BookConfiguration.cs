using FadakTest.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FadakTest.Repository.Configurations
{
    internal class BookConfiguration : ResourceConfiguration<Book>
    {
        public override void ConfigureDerived(EntityTypeBuilder<Book> builder)
        {

        }
    }
}
