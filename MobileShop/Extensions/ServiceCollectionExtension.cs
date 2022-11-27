namespace Microsoft.Extensions.DependencyInjection
{
    using Microsoft.EntityFrameworkCore;
    using MobileShop.Infrastructure.Data;

    public static class ServiceCollectionExtension
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder services)
        {
            using var scopedServices = services.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<MobileShopDbContext>();
            SeedCategory(data);
            SeedManifacture(data);
            SeedModel(data);
            return services;
        }

        public static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<MobileShopDbContext>(options =>
    options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        private static void SeedCategory(MobileShopDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            //data.Categories.AddRange(new[]
            //{
            //    new Category { Name = "Phone"},
            //    new Category { Name = "Tablet"},
            //});

            //data.SaveChanges();
        }

        private static void SeedManifacture(MobileShopDbContext data)
        {
            if (data.Manufactures.Any())
            {
                return;
            }

            //data.Manufactures.AddRange(new[]
            //{
            //    new Manufacturer { Name = "Nokia", Country = "Finland"},
            //    new Manufacturer { Name = "Samsung", Country = "West Korea"},
            //    new Manufacturer { Name = "Motorola", Country = "USA"},
            //});

            //data.SaveChanges();
        }

        private static void SeedModel(MobileShopDbContext data)
        {
            if (data.Models.Any())
            {
                return;
            }

            //data.Models.AddRange(new[]
            //{
            //    new Model { TypeBatery = "Nickel Metal Hydride", Size = 100},
            //    new Model { TypeBatery = "Lithium-Ion", Size = 200},
            //    new Model { TypeBatery = "Lithium Polimer", Size = 300},

            //});

            //data.SaveChanges();
        }
    }
}
