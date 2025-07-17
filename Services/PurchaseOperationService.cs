using Ebobo.Data;
using Ebobo.Models;
using Microsoft.EntityFrameworkCore;

namespace Ebobo.Services;

public class PurchaseOperationService : IPurchaseOperationService
{
    private readonly EboboDbContext _context;

    public PurchaseOperationService(EboboDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PurchaseOperation>> GetOperationsByUserAsync(int userId)
    {
        var r = new List<PurchaseOperation>()
        {
            new PurchaseOperation
            {
                Amount = 123,
                Description = "description",
                Id = 1,
                OperationDate = DateTime.Now,
                Status = "good",
                UserId = 1,
                User = new User
                {
                    Email = "qwe@gmaill.com",
                    Id = 1,
                    Username = "diman"
                }
            },
            new PurchaseOperation
            {
                Amount = 1234,
                Description = "description1",
                Id = 2,
                OperationDate = DateTime.Now,
                Status = "good",
                UserId = 1,
                User = new User
                {
                    Email = "qwe@gmaiql.com",
                    Id = 1,
                    Username = "diman1"
                }
            }
        };
        return r;
    }

    public async Task<PurchaseOperation?> GetOperationDetailsAsync(int operationId)
    {
        return new PurchaseOperation
        {
            Amount = 123,
            Description = "description",
            Id = 1,
            OperationDate = DateTime.Now,
            Status = "good",
            UserId = 1,
            User = new User
            {
                Email = "qwe@gmaill.com",
                Id = 1,
                Username = "diman"
            }
        };
    }
} 