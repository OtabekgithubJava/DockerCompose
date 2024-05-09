using Course.Application.Abstraction;
using Course.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Course.Infrastructure;

public static class CourseDependencyInjection
{
     public static IServiceCollection AddCourseInfrastructure(this IServiceCollection services,
         IConfiguration configuration)
     {
         services.AddDbContext<ICourseDbContext, CourseDbContext>(options =>
         {
             options.UseNpgsql(configuration.GetConnectionString("CourseConnectionString"));
         });
         
         services.AddScoped<CourseDbContext>();

         return services;
     }
}