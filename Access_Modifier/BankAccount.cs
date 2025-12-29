/*Bank Account Management
● Create a BankAccount class with:
o accountNumber (public)
o accountHolder (protected)
o balance (private)
● Implement methods to:
o Access and modify balance using public methods.
o Create a subclass SavingsAccount to demonstrate access to accountNumber
and accountHolder.*/



using System;

public class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public Method for Access Balance
    public double GetBalance()
    {
        return balance;
    }

    // Modify the Balance
    public void SetBalance(double balance)
    {
        this.balance = balance;
    }
}

// Sub Class
public class SavingsAccount : BankAccount
{
    string type;

    public SavingsAccount(int accountNumber, string accountHolder, double balance, string type) : base(accountNumber, accountHolder, balance)
    {
        this.type = type;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Account Number  :  {accountNumber}");
        Console.WriteLine($"Account Holder  :  {accountHolder}");
        Console.WriteLine($"balance :  {GetBalance()}");
        Console.WriteLine($"Type  :  {type}");

    }
}

