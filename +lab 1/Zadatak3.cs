using System;

namespace z3
{
    public enum AccountType
    {
        Savings,
        Checking,
        Giro
    }

    public struct BankAccount
    {
        int accountNumber;
        double balance;
        AccountType accountType;

        public BankAccount(int accountNumber, double balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }

        public void Info()
        {
            Console.WriteLine("Account number: " + accountNumber);
            Console.WriteLine("Balance: " + balance.ToString("C"));
            Console.WriteLine("Account type: " + accountType.ToString());
            Console.WriteLine();
        }
    }

    internal class Zadatak3
    {
        static void Main(string[] args)
        {
            BankAccount[] bankAccounts = new BankAccount[]
            {
                new BankAccount(1, 4864.55, AccountType.Checking),
                new BankAccount(2, 0.02, AccountType.Savings),
                new BankAccount(3, 94561.81, AccountType.Giro),
                new BankAccount(4, 14.42, AccountType.Giro),
                new BankAccount(5, 947.23, AccountType.Checking)
            };

            foreach (BankAccount account in bankAccounts)
            {
                account.Info();
            }
        }

    }
}
