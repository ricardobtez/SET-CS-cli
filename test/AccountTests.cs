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
            Account acc = new Account(System.DateTime.Now);
            Assert.True(acc.GetType() == typeof(Account));
        }
        [Fact]
        public void DebitAccountIsAccount()
        {
            DebitAccount acc = new DebitAccount(System.DateTime.Now);
            Assert.True(acc.GetType().IsSubclassOf(typeof(Account)));
        }
        [Fact]
        public void CreditAccountIsAccount()
        {
            CreditAccount acc = new CreditAccount(System.DateTime.Now);
            Assert.True(acc.GetType().IsSubclassOf(typeof(Account)));
        }
    }
}
