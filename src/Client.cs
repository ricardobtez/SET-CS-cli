
using System.Collections.Generic;

namespace SET_CS
{
    public class Client
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private System.DateTime birthDate;
        private List<Account> accounts;

        public Client(string firstName,
                      string middleName,
                      string lastName,
                      System.DateTime birthDate)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.accounts = new List<Account>();
        }

        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;
        public System.DateTime GetBirthDate() => birthDate;
        public List<Account> GetAccounts() => accounts;

        public void AddAccount(ref Account account)
        {
            accounts.Add(account);
        }
    }
}
