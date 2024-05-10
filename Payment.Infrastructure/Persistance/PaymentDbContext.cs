using Microsoft.EntityFrameworkCore;
using Payment.Application.Abstraction;

namespace Payment.Infrastructure.Persistance;

public class PaymentDbContext: DbContext, IPaymentDbContext
{
    public PaymentDbContext(DbContextOptions<PaymentDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<SharedModels.SharedModels.Payment> Payments { get; set; }
}