namespace Accommodation.Infrastructure.DependencyInjections;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("Connect")));

        return services;
    }
}
