using Microsoft.Extensions.DependencyInjection;

namespace ManuHub.Toast.BS;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorToast(this IServiceCollection services, Action<ToastOptions>? configure = null)
    {
        var options = new ToastOptions();
        configure?.Invoke(options);

        services.AddScoped<IToastService>(_ => new ToastService
        {
            MaxToasts = options.MaxToasts,
            Position = options.Position
        });

        return services;
    }
}