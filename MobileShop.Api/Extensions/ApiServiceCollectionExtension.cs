namespace Microsoft.Extensions.DependencyInjection
{
    using Microsoft.EntityFrameworkCore;
    using MobileShop.Infrasructure.Data;

    public static class ApiServiceCollectionExtension
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddApiDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

            return services;
        }
    }
}
