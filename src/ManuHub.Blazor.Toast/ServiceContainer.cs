using Microsoft.Extensions.DependencyInjection;

namespace ManuHub.Blazor.Toast;

public static class ServiceContainer
{
    public static IServiceCollection AddBlazorToast(this IServiceCollection services)
    {
        services.AddScoped<IToastService, ToastService>();
        return services;
    }
}