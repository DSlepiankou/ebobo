using Microsoft.EntityFrameworkCore;
using Ebobo.Models;

namespace Ebobo.Data;

public class EboboDbContext : DbContext
{
    public EboboDbContext(DbContextOptions<EboboDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<PurchaseOperation> PurchaseOperations => Set<PurchaseOperation>();
} 