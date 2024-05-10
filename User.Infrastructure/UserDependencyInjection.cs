using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using User.Application.Abstraction;
using User.Infrastructure.Persistance;

namespace User.Infrastructure;

public static class UserDependencyInjection
{
    public static IServiceCollection AddUserInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<IUserDbContext, UserDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("UserConnectionString"));
        });

        services.AddScoped<UserDbContext>();

        return services;
    }
}