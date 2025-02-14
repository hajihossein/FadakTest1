using FadakTest.Repository;
using Microsoft.EntityFrameworkCore;

namespace FadakTest
{
    public class DatabaseMigrator
    {
        private readonly ILogger<DatabaseMigrator> _logger;
        private readonly IFadakTestDbContextProvider _contextProvider;
        private readonly IHostEnvironment _environment;

        public DatabaseMigrator(ILogger<DatabaseMigrator> logger, IFadakTestDbContextProvider contextProvider, IHostEnvironment environment)
        {
            _logger = logger;
            _contextProvider = contextProvider;
            _environment = environment;
        }

        public void Migrate()
        {
            try
            {
                if (_environment.IsDevelopment())
                    return;

                using var scope = _contextProvider.GetContext();
                var context = scope.Context;

                context.Database.Migrate();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
