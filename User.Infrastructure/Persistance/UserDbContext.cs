using Microsoft.EntityFrameworkCore;
using User.Application.Abstraction;

namespace User.Infrastructure.Persistance;

public class UserDbContext: DbContext, IUserDbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<SharedModels.SharedModels.User> Users { get; set; }
}