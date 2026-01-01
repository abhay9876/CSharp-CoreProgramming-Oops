/*Bank Account Types

○ Description: Model a banking system with different account types using
hierarchical inheritance. BankAccount is the superclass, with
SavingsAccount, CheckingAccount, and FixedDepositAccount as
subclasses.
○ Tasks:
■ Define a base class BankAccount with attributes like AccountNumber
and Balance.
■ Define subclasses SavingsAccount, CheckingAccount, and
FixedDepositAccount, each with unique attributes like
interestRate for SavingsAccount and WithdrawalLimit for
CheckingAccount.
■ Implement a method DisplayAccountType() in each subclass to
specify the account type.

○ Goal: Explore hierarchical inheritance, demonstrating how each subclass can
have unique attributes while inheriting from a shared superclass.*/



using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    // Virtual method for override
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Generic Bank Account");
    }
}

//Savings Account Class
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber,double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
    }
}

// Checking Account Class
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
    }
}

// Fix Deposit account
class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; } 

    public FixedDepositAccount(string accountNumber,double balance, int maturityPeriod)
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
    }
}



