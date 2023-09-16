using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proyect.Presenters;
using Proyect.RepositoryEFCore;
using Proyect.UseCases;

namespace Proyect.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProyectDependencies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCaseServices();
            services.AddPresenters();
            return services;
        }
    }
}
