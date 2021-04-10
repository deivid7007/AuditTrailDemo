namespace AuditTrailDemo.Presentation.Api.Extensions
{
    using AuditTrailDemo.Persistence.Contexts;
    using AuditTrailDemo.Persistence.DataEntities.ChangeLog;
    using AuditTrailDemo.Persistence.DataEntities.Product;
    using AuditTrailDemo.Persistence.Interfaces.Repository;
    using AuditTrailDemo.Persistence.Services.Repository;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection InitializeDepdendencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Presentation:

            // Infrastructure:

            // Boundries Application.Infrastructure:

            // Application:

            // Persistence:
            services.AddScoped<DbContext, AuditTrailContext>();
            services.AddScoped<IGenericRepository<ProductDataEntity>, GenericRepository<ProductDataEntity>>();
            services.AddScoped<IGenericRepository<ChangeLogDataEntity>, GenericRepository<ChangeLogDataEntity>>();

            return services;
        }

        public static IServiceCollection MapConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            // Here should come any appsettings models representations

            return services;
        }

        internal static IServiceCollection InitializeHostedServices(this IServiceCollection services)
        {
            // Here should come any Hosted services initializations

            return services;
        }

        internal static IServiceCollection InitializeDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuditTrailContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultDB"), opts => opts.EnableRetryOnFailure(3, TimeSpan.FromSeconds(5), null)));

            return services;
        }
    }
}
