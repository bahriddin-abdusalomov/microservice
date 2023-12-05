namespace Accommodation.Application.DependencyInjections;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddScoped<IFileService, FileService>();
        return services;
    }
}
 