using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0; 
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal canceled.");
            }
            else
            {
                balance -= amount;
            }
        }
        
        public decimal GetBalance()
        {
            return balance;
        }
    }

    public class Program
    {
        public static void Main()
        {            
            BankAccount account = new BankAccount("123456");            
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine($"Final Balance: {account.GetBalance():C}");
        }
    }
}
