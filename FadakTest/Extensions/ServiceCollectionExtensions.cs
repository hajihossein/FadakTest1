using FadakTest.Controllers;
using FadakTest.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FadakTest.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static void AddFadakTestDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string con = configuration.GetSection("ConnectionStrings:sqlConnection").Value;

            services.AddDbContext<FadakTestDbContext>(options => options.UseSqlServer(con));

            services.AddIdentityEntityFramework();

            services.AddSingleton<DatabaseMigrator>();
        }

        public static IServiceCollection AddIdentityEntityFramework(this IServiceCollection services)
        {
            return services.AddSingleton(typeof(IFadakTestDbContextProvider), typeof(FadakTestDbContextProvider));
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IMediatRSenderService, MediatRSenderService>();

            return services;
        }

    }
}
