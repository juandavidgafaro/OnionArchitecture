using Microsoft.Extensions.DependencyInjection;
using Proyect.UseCases.CreateProduct;
using Proyect.UseCases.DeleteProduct;
using Proyect.UseCases.GetAllProducts;
using Proyect.UseCasesPorts;

namespace Proyect.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            services.AddTransient<IDeleteProductInputPort, DeleteProductInteractor>();

            return services;
        }
    }
}
