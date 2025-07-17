using Ebobo.Models;

namespace Ebobo.Services;

public interface IPurchaseOperationService
{
    Task<IEnumerable<PurchaseOperation>> GetOperationsByUserAsync(int userId);
    Task<PurchaseOperation?> GetOperationDetailsAsync(int operationId);
} 