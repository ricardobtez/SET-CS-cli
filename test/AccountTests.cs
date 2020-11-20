using System;
using Xunit;
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
            decimal transaction = 200.5m;
            Account acc = new Account();
            acc.SetTransaction(TransactionType.Incoming, transaction);
            Assert.Equal(transaction, acc.GetBalance());
        }
        [Fact]
        public void DebitIncomingTransaction()
        {
            decimal transaction = 350.67m;
            DebitAccount acc = new DebitAccount();
            acc.SetTransaction(TransactionType.Incoming, transaction);
            Assert.Equal(transaction, acc.GetBalance());
        }
        [Fact]
        public void CreditIncomingTransaction()
        {
            decimal transaction = 550m;
            CreditAccount acc = new CreditAccount();
            acc.SetTransaction(TransactionType.Incoming, transaction);
            Assert.Equal(transaction, acc.GetBalance());
        }
        [Fact]
        public void AccountOutgoingTransaction()
        {
            decimal transaction = 20m;
            Account acc = new Account();
            acc.SetTransaction(TransactionType.Outgoing, transaction);
            Assert.Equal(-transaction, acc.GetBalance());
        }
        [Fact]
        public void DebitOutgoingTransaction()
        {
            decimal transaction = 45.0m;
            DebitAccount acc = new DebitAccount();
            acc.SetTransaction(TransactionType.Outgoing, transaction);
            Assert.Equal(-transaction, acc.GetBalance());
        }
        [Fact]
        public void CreditOutgoingTransaction()
        {
            decimal transaction = 68.345m;
            CreditAccount acc = new CreditAccount();
            acc.SetTransaction(TransactionType.Outgoing, transaction);
            Assert.Equal(-transaction, acc.GetBalance());
        }
    }
}
