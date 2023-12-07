using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
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
        BankAccount myAccount = new BankAccount("ABC123V456YTA");
        myAccount.Deposit(1540);
        myAccount.Withdraw(400);
        decimal balance = myAccount.GetBalance();
        Console.WriteLine("Final balance: " + balance);
    }
}