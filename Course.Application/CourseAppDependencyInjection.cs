using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Course.Application;

public static class CourseAppDependencyInjection
{
    public static IServiceCollection AddCourseApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}