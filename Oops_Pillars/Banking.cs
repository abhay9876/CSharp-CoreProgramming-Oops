/*Banking System
Description: Create a banking system with different account types:
● Define an abstract class BankAccount with fields like accountNumber, holderName,
and balance.
● Add methods like Deposit(double amount), Withdraw(double amount), and an abstract
method CalculateInterest().
● Implement subclasses SavingsAccount and CurrentAccount with unique interest
calculations.
● Create an interface ILoanable with methods ApplyForLoan() and
CalculateLoanEligibility().
● Use encapsulation to secure account details and restrict unauthorized access.
● Demonstrate polymorphism by processing different account types and calculating
interest dynamically.*/



using System;

// Abstract class
public abstract class BankAccount
{
    // Encapsulation
    private int accountNumber;
    private string holderName;
    protected double balance;

    // Constructor
    public BankAccount(int accNo, string name, double balance)
    {
        this.accountNumber = accNo;
        this.holderName = name;
        this.balance = balance;
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public string HolderName
    {
        get { return holderName; }
    }

    public double Balance
    {
        get { return balance; }
    }

    // Common methods
    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

  
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    // Abstract method
    public abstract double CalculateInterest();
}

// Interface for loan
public interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}


// Savings Account
public class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int accNo, string name, double balance)
        : base(accNo, name, balance)
    {
    }

    // Interest calculation 
    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan apply for Saving Account");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5;
    }
}

// Current Account Class
public class CurrentAccount : BankAccount
{
    public CurrentAccount(int accNo, string name, double balance)
        : base(accNo, name, balance)
    {
    }
    public override double CalculateInterest()
    {
        return balance * 0.01;   
    }
}



