
public enum AccountType
{
    Debit,
    Credit,
    Investment
}

public enum TransactionType
{
    Incoming,
    Outgoing
}

namespace SET_CS
{
    public class Account
    {
        protected AccountType accountType;
        protected decimal balance;
        protected System.DateTime openDate;

        public Account(System.DateTime openDate,
                       AccountType type = AccountType.Debit)
        {
            this.accountType = type;
            this.openDate = openDate;
        }

        public decimal GetBalance() => balance;
        public AccountType GetAccountType() => accountType;
        public string GetOpenDate() => openDate.ToString();

        public void SetTransaction(TransactionType transactionType, decimal amount)
        {
            if (transactionType == TransactionType.Incoming)
                balance += amount;
            else
                balance -= amount;
        }
        
        public override string ToString()
        {
            return "Account";
        }
    }
}

