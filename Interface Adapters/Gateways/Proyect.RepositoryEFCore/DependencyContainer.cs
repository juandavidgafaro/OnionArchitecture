using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyect.Entities.Interfaces;
using Proyect.RepositoryEFCore.DataContext;
using Proyect.RepositoryEFCore.Repositories;

namespace Proyect.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProyectContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("store")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
