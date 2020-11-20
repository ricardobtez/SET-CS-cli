
public enum TransactionType
{
    Incoming,
    Outgoing
}
namespace SET_CS
{
public class Transaction
{
    public TransactionType type { get; }
    public decimal amount { get; }
    public Transaction(TransactionType type, decimal amount)
    {
        this.type = type;
        this.amount = amount;
    }
}
}
