using Microsoft.EntityFrameworkCore;
using Progress.Application.Abstraction;

namespace Progress.Infrastructure.Persistance;

public class ProgressDbContext: DbContext, IProgressDbContext
{
    public ProgressDbContext(DbContextOptions<ProgressDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<SharedModels.SharedModels.Progress> Progresses { get; set; }
}