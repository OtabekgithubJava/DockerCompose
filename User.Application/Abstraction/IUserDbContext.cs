using Microsoft.EntityFrameworkCore;

namespace User.Application.Abstraction;

public interface IUserDbContext
{
    DbSet<SharedModels.SharedModels.User> Users { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}