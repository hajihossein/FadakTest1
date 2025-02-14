using Microsoft.Extensions.DependencyInjection;

namespace FadakTest.Repository
{
    public class FadakTestDbContextProvider : IFadakTestDbContextProvider
    {
        private readonly IServiceScopeFactory _factory;

        public FadakTestDbContextProvider(IServiceScopeFactory factory)
        {
            _factory = factory;
        }

        public ScopedContext GetContext()
        {
            return new ScopedContext(_factory.CreateScope());
        }
    }
}
