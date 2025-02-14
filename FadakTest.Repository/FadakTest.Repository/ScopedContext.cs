using Microsoft.Extensions.DependencyInjection;

namespace FadakTest.Repository
{
    public class ScopedContext : IDisposable
    {
        public IServiceScope Scope { get; }
        public FadakTestDbContext Context { get; }
        public ScopedContext(IServiceScope scope)
        {
            Scope = scope;
            Context = scope.ServiceProvider.GetRequiredService<FadakTestDbContext>();
        }

        public void Dispose()
        {
            Scope?.Dispose();
        }
    }
}
