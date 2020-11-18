
public enum AccountType
{
    Debit,
    Credit,
    Investment
}

public enum TransactionType
{
    Incoming,
    Outgoing,
}

public class Account
{
    protected string clientName;
    protected AccountType accountType;
    protected decimal balance;

    public Account(string name, AccountType type)
    {
        clientName = name;
        accountType = type;
    }
    public decimal GetBalance() => balance;
    public AccountType GetAccountType() => accountType;
    public string GetClientName() => clientName;

    public void SetTransaction(TransactionType transactionType, decimal amount)
    {
        if (transactionType == TransactionType.Incoming)
            balance += amount;
        else
            balance -= amount;
    }
}

