
namespace SET_CS
{
    public class DebitAccount : Account
    {
        public DebitAccount(System.DateTime openDate) :
            base(openDate, AccountType.Debit)
        {
        }
        public override string ToString()
        {
            return base.ToString() + ", Debit";
        }
    }
}
