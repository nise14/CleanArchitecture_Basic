using Microsoft.Extensions.DependencyInjection;
using UseCasesPorts;

namespace Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<ICreateProductOutputPort, CreateProductPresenters>();
        services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();

        return services;
    }
}