using System.Collections.Generic;

public enum AccountType
{
    Debit,
    Credit,
    Investment
}


namespace SET_CS
{
    public class Account
    {
        protected AccountType accountType;
        protected List<Transaction> transactions;
        protected System.DateTime openDate = new System.DateTime(2020,01,01);
        
        public Account(AccountType type = AccountType.Debit)
        {
            this.accountType = type;
            this.transactions = new List<Transaction>();
        }

        public Account(System.DateTime openDate,
                       AccountType type = AccountType.Debit) :
            this(type)
        {
            this.openDate = openDate;
        }

        public decimal GetBalance() => CalculateBalance();
        public AccountType GetAccountType() => accountType;
        public System.DateTime GetOpenDate() => openDate;

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public void AddTransactions(List<Transaction> transactions)
        {
            this.transactions.AddRange(transactions);
        }

        public override string ToString()
        {
            return "Account";
        }

        protected virtual decimal CalculateBalance()
        {
            decimal result = 0.0m;
            foreach(Transaction transaction in this.transactions)
            {
                if (transaction == null)
                {
                    System.Console.WriteLine("This is weird");
                }
                if (transaction.type == TransactionType.Incoming)
                {
                    result += transaction.amount;
                }
                else
                {
                    result -= transaction.amount;
                }
            }
            return result;
        }
    }
}

