using FadakTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics;

namespace FadakTest.Repository.Configurations
{
    internal abstract class ResourceConfiguration<TResource> : IEntityTypeConfiguration<TResource> where TResource : BaseEntity
    {
        protected const string SequenceIdFieldName = "_seqId";
        public void Configure(EntityTypeBuilder<TResource> builder)
        {
            builder.UsePropertyAccessMode(PropertyAccessMode.Field);

            builder.Property<long>(SequenceIdFieldName)
                .UseIdentityColumn<long>()
                .ValueGeneratedOnAddOrUpdate();

            builder.HasIndex(SequenceIdFieldName)
                .IsClustered();

            builder.Property(r => r.Id)
                .ValueGeneratedNever();

            builder.HasKey(r => r.Id)
                .IsClustered(false);

            builder.Property(r => r.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasQueryFilter(e => !e.IsDeleted);

            ConfigureDerived(builder);

        }
        public abstract void ConfigureDerived(EntityTypeBuilder<TResource> builder);
    }
}
