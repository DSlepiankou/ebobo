using System;

namespace Ebobo.Models;

public class PurchaseOperation
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public DateTime OperationDate { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = default!;
    public string Status { get; set; } = default!;
} 