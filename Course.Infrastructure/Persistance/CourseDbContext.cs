using Course.Application.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Persistance;

public class CourseDbContext: DbContext, ICourseDbContext
{

    public CourseDbContext(DbContextOptions<CourseDbContext> options) :
        base(options)
    {
        
    }
    
    public DbSet<SharedModels.SharedModels.Course> Courses { get; set; }
}