using System;
using Xunit;
using System.Collections.Generic;
using SET_CS;

namespace Program.Test.Accounts
{
    public class Account_ConstructorTest
    {
        [Fact]
        public void DefaultConstructor()
        {
            Account acc = new Account();
            Assert.True(acc.GetType() == typeof(Account));
        }
        [Fact]
        public void AccountDebitType()
        {
            Account acc = new Account(AccountType.Debit);
            Assert.True(acc.GetType() == typeof(Account));
        }
        [Fact]
        public void AccountCreditType()
        {
            Account acc = new Account(AccountType.Credit);
            Assert.True(acc.GetType() == typeof(Account));
        }
        [Fact]
        public void AccountInvestmentType()
        {
            Account acc = new Account(AccountType.Investment);
            Assert.True(acc.GetType() == typeof(Account));
        }
        [Fact]
        public void DebitAccountIsAccount()
        {
            DebitAccount acc = new DebitAccount();
            Assert.True(acc.GetType().IsSubclassOf(typeof(Account)));
        }
        [Fact]
        public void CreditAccountIsAccount()
        {
            CreditAccount acc = new CreditAccount();
            Assert.True(acc.GetType().IsSubclassOf(typeof(Account)));
        }
        [Fact]
        public void DebitAccountIsDebit()
        {
            DebitAccount acc = new DebitAccount();
            Assert.True(acc.GetAccountType() == AccountType.Debit);
        }
        [Fact]
        public void CreditAccountIsCredit()
        {
            CreditAccount acc = new CreditAccount();
            Assert.True(acc.GetAccountType() == AccountType.Credit);
        }
        [Fact]
        public void DebitAccountSameDefaultOpenDate()
        {
            Account acc = new Account();
            DebitAccount debit = new DebitAccount();
            Assert.Equal(acc.GetOpenDate(), debit.GetOpenDate());
        }
        [Fact]
        public void CreditAccountSameDefaultOpenDate()
        {
            Account acc = new Account();
            CreditAccount credit = new CreditAccount();
            Assert.Equal(acc.GetOpenDate(), credit.GetOpenDate());
        }
        [Fact]
        public void DebitAccountDateConstructor()
        {
            Account acc = new Account();
            DebitAccount debit = new DebitAccount(new System.DateTime(2002, 05, 19));
            Assert.NotEqual(acc.GetOpenDate(), debit.GetOpenDate());
        }
        [Fact]
        public void CreditAccountDateConstructor()
        {
            Account acc = new Account();
            CreditAccount credit = new CreditAccount(new System.DateTime(2001, 12, 20));
            Assert.NotEqual(acc.GetOpenDate(), credit.GetOpenDate());
        }
    }
    
    public class Account_MethodsTest
    {
        [Fact]
        public void AccountDefaultBalance()
        {
            Account acc = new Account();
            Assert.Equal(0m, acc.GetBalance());
        }
        [Fact]
        public void DebitDefaultBalance()
        {
            DebitAccount acc = new DebitAccount();
            Assert.Equal(0m, acc.GetBalance());
        }
        [Fact]
        public void CreditDefaultBalance()
        {
            CreditAccount acc = new CreditAccount();
            Assert.Equal(0m, acc.GetBalance());
        }
        [Fact]
        public void AccountIncomingTransaction()
        {
            decimal amount = 200.5m;
            Transaction transaction = new Transaction(TransactionType.Incoming, amount);
            Account acc = new Account();
            acc.AddTransaction(transaction);
            Assert.Equal(amount, acc.GetBalance());
        }
        [Fact]
        public void DebitIncomingTransaction()
        {
            decimal amount = 350.67m;
            Transaction transaction = new Transaction(TransactionType.Incoming, amount);
            DebitAccount acc = new DebitAccount();
            acc.AddTransaction(transaction);
            Assert.Equal(amount, acc.GetBalance());
        }
        [Fact]
        public void CreditIncomingTransaction()
        {
            decimal amount = 550m;
            Transaction transaction = new Transaction(TransactionType.Incoming, amount);
            CreditAccount acc = new CreditAccount();
            acc.AddTransaction(transaction);
            Assert.Equal(amount, acc.GetBalance());
        }
        [Fact]
        public void AccountOutgoingTransaction()
        {
            decimal amount = 20m;
            Transaction transaction = new Transaction(TransactionType.Outgoing, amount);
            Account acc = new Account();
            acc.AddTransaction(transaction);
            Assert.Equal(-amount, acc.GetBalance());
        }
        [Fact]
        public void DebitOutgoingTransaction()
        {
            decimal amount = 45.0m;
            Transaction transaction = new Transaction(TransactionType.Outgoing, amount);
            DebitAccount acc = new DebitAccount();
            acc.AddTransaction(transaction);
            Assert.Equal(-amount, acc.GetBalance());
        }
        [Fact]
        public void CreditOutgoingTransaction()
        {
            decimal amount = 68.345m;
            Transaction transaction = new Transaction(TransactionType.Outgoing, amount);
            CreditAccount acc = new CreditAccount();
            acc.AddTransaction(transaction);
            Assert.Equal(-amount, acc.GetBalance());
        }
        [Fact]
        public void AccountListOfIncomingTransactions()
        {
            decimal[] values = { 200.0m, 200.0m, 200.0m };
            decimal result = 0.0m;
            List<Transaction> transactions = new List<Transaction>(3);

            foreach(var amount in values)
            {
                transactions.Add(new Transaction(TransactionType.Incoming, amount));
                result += amount;
            }
            
            Account acc = new Account();
            acc.AddTransactions(transactions);
            Assert.Equal(result, acc.GetBalance());
        }
    }
}
