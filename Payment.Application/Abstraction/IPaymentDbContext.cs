using Microsoft.EntityFrameworkCore;

namespace Payment.Application.Abstraction;

public interface IPaymentDbContext
{
    public DbSet<SharedModels.SharedModels.Payment> Payments { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}