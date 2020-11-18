using System;

namespace SET_CS_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Client currentClient = new Client("Ricardo", "", "Benitez", new System.DateTime(1995, 05, 19));
            Account account = new DebitAccount(currentClient, System.DateTime.Now);
            CreditAccount creditAcc = new CreditAccount(currentClient, System.DateTime.Now);

            System.Console.WriteLine(account.GetOpenDate());
            System.Console.WriteLine(creditAcc.GetOpenDate());
            
            System.Console.WriteLine(creditAcc.GetClient().GetBirthDate());
        }
    }
}
