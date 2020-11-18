
public class CreditAccount : Account
{
    public CreditAccount(Client client, System.DateTime openDate) :
        base(client, openDate, AccountType.Credit)
    {
    
    }
}
