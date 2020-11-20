
namespace SET_CS
{
    public class CreditAccount : Account
    {
        public CreditAccount() :
            base(AccountType.Credit)
        {
        }
        public CreditAccount(System.DateTime openDate) :
            base(openDate, AccountType.Credit)
        {
        }
    }
}
