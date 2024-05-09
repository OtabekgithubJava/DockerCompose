using Microsoft.EntityFrameworkCore;

namespace Course.Application.Abstraction;

public interface ICourseDbContext
{
    public DbSet<SharedModels.SharedModels.Course> Courses { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}