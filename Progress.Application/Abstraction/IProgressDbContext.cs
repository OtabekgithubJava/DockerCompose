using Microsoft.EntityFrameworkCore;

namespace Progress.Application.Abstraction;

public interface IProgressDbContext
{
    public DbSet<SharedModels.SharedModels.Progress> Progresses { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}