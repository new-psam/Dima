using Dima.Core.Enums;

namespace Dima.Core.Models;

public class Transaction // Entrada ou Saída
{
    public long Id { get; set; }
    public string Title { get; set; } =  String.Empty;

    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceiveAt { get; set; }

    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    public decimal Amount { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = String.Empty;
}