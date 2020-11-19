using System;
using Xunit;
using SET_CS;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Account acc = new Account(System.DateTime.Now);
        }
    }
}
