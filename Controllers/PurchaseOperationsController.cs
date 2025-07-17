using Ebobo.Models;
using Ebobo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ebobo.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class PurchaseOperationsController : ControllerBase
{
    private readonly IPurchaseOperationService _purchaseOperationService;

    public PurchaseOperationsController(IPurchaseOperationService purchaseOperationService)
    {
        _purchaseOperationService = purchaseOperationService;
    }

    /// <summary>
    /// Gets all purchase operations for a specific user.
    /// </summary>
    [HttpGet("user/{userId}")]
    public async Task<ActionResult<IEnumerable<PurchaseOperation>>> GetOperationsByUser(int userId)
    {
        var operations = await _purchaseOperationService.GetOperationsByUserAsync(userId);
        return Ok(operations);
    }

    /// <summary>
    /// Gets details for a specific purchase operation.
    /// </summary>
    [HttpGet("{operationId}")]
    public async Task<ActionResult<PurchaseOperation>> GetOperationDetails(int operationId)
    {
        var operation = await _purchaseOperationService.GetOperationDetailsAsync(operationId);
        if (operation == null)
        {
            return NotFound();
        }
        return Ok(operation);
    }
} 