using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Payment.Application;

public static class PaymentAppDependencyInjection
{
    public static IServiceCollection AddPaymentApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}