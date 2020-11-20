
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
        protected System.DateTime openDate = new System.DateTime(2020,01,01);
        
        public Account(AccountType type = AccountType.Debit)
        {
            this.accountType = type;
            this.balance = 0m;
        }

        public Account(System.DateTime openDate,
                       AccountType type = AccountType.Debit) :
            this(type)
        {
            this.openDate = openDate;
        }

        public decimal GetBalance() => balance;
        public AccountType GetAccountType() => accountType;
        public System.DateTime GetOpenDate() => openDate;

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

