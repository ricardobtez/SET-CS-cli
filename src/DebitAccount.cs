
namespace SET_CS
{
public class DebitAccount : Account
{
    public DebitAccount(Client client, System.DateTime openDate) :
        base(client, openDate, AccountType.Debit)
    {
    }
}
}
