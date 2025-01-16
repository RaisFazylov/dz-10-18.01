using System.Collections.Generic;

namespace BankingSystem
{
    public class BankAccountFactory
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        private int nextAccountNumber = 1;

        public int CreateAccount()
        {
            var account = new BankAccount(nextAccountNumber);
            accounts[nextAccountNumber] = account;
            nextAccountNumber++;
            return account.AccountNumber;
        }

        public bool CloseAccount(int accountNumber)
        {
            return accounts.Remove(accountNumber);
        }
    }
}
