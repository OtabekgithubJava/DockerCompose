using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payment.Application.Abstraction;
using Payment.Infrastructure.Persistance;

namespace Payment.Infrastructure;

public static class PaymentDependencyInjection
{
    public static IServiceCollection AddPaymentInfrastructure(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        serviceCollection.AddDbContext<IPaymentDbContext, PaymentDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PaymentConnectionString"));
        });

        serviceCollection.AddScoped<PaymentDbContext>();

        return serviceCollection;
    }
}