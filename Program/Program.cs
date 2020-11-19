using System;
using SET_CS;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Client currentClient = new Client("Ricardo", "", "Benitez", new System.DateTime(1995, 05, 19));
            Account account = new DebitAccount(System.DateTime.Now);
            Account creditAcc = new CreditAccount(System.DateTime.Now);

            currentClient.AddAccount(ref account);
            currentClient.AddAccount(ref creditAcc);
        }
    }
}
