using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Progress.Application.Abstraction;
using Progress.Infrastructure.Persistance;

namespace Progress.Infrastructure;

public static class ProgressDependencyInjection
{
    public static IServiceCollection AddProgressInfrastructure(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDbContext<IProgressDbContext, ProgressDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ProgressConnectionString"));
        });

        service.AddScoped<ProgressDbContext>();

        return service;
    }
}