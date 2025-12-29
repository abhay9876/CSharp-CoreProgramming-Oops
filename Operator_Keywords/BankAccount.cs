/*Bank Account System
Create a BankAccount class with the following features:
● static:
o A static variable bankName shared across all accounts.
o A static method GetTotalAccounts() to display the total number of accounts.
● this:
o Use this to resolve ambiguity in the constructor when initializing
AccountHolderName and AccountNumber.

● readonly:
o Use a readonly variable AccountNumber to ensure it cannot be changed once
assigned.
● is operator:
o Check if an account object is an instance of the BankAccount class before
displaying its details.*/



using System;

public class BankAccount
{
	public string aacountHolder;
	public readonly int accountNumber;

	public static string bankName="Sate Bank of India";
	public static int totalAccount = 0;

	//Constructor
	public BankAccount(string accoundHolder , int accountNumber)
	{
		this.aacountHolder = accoundHolder;
		this.accountNumber = accountNumber;
		totalAccount++;
	}

	//Get Total Accounts
	public static int GetTotalAccounts()
	{
		return totalAccount;
	}


	public void DisplayDetails()
	{
		Console.WriteLine($"Bank Name : {bankName}");
        Console.WriteLine($"Account Holder Name : {aacountHolder}");
        Console.WriteLine($"Account Number : {accountNumber}");
    }
}

public class Bank
{
	public static void Run()
	{
		Console.WriteLine("Welcome to SBI......");
		Console.WriteLine("Enter the Account Holder name : ");
		string accHolder = Console.ReadLine();
		Console.WriteLine("Enter Bank Account Number : ");
		int accNumber = Convert.ToInt32(Console.ReadLine());

		// New Object for Comparison
		object obj = new BankAccount(accHolder, accNumber);

		if(obj is BankAccount obj2)
		{
			obj2.DisplayDetails();
		}
		else
		{
			Console.WriteLine("Object is not a valid Bank Account Instance...");
		}

		Console.WriteLine("Total Bank Accounts are : " + BankAccount.GetTotalAccounts());
	}
}
