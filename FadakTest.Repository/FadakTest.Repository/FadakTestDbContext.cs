using FadakTest.Domain.Models;
using FadakTest.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FadakTest.Repository
{
    public class FadakTestDbContext : DbContext
    {
        public FadakTestDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
