using Microsoft.Extensions.DependencyInjection;
using Proyect.UseCasesPorts;

namespace Proyect.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            services.AddScoped<IDeleteProductOutputPort, DeleteProductPresenter>();

            return services;
        }
    }
}
