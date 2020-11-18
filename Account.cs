
public enum AccountType
{
    Debit,
    Credit,
    Investment
}

public class Account
{
    protected string clientName;
    protected AccountType accountType;

    public Account(string name, AccountType type)
    {
        clientName = name;
        accountType = type;
    }
}

