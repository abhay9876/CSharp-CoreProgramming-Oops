/*Bank and Account Holders (Association)
Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
Tasks:
● Define a Bank class and a Customer class.
● Use an association relationship to show that each Customer has an account in a
Bank.
● Implement methods that enable communication, such as OpenAccount() in the Bank
class and ViewBalance() in the Customer class.
Goal: Illustrate association by setting up a relationship between customers and the bank.*/



using System;


// Customer Class
public class Customer
{
	public string name { get;set ;}
	Dictionary<Bank, double> accounts = new Dictionary<Bank, double>();
	

	//Constructor
	public Customer(string name )
	{
		this.name = name;
		
	}
	// Method to add account
	public void AddAccount(Bank bank , double salary)
	{
		accounts[bank] = salary;
	}

	// Method to view Balance
	public void ViewBalance(Bank bank)
	{
		if (accounts.ContainsKey(bank))
		{
			Console.WriteLine($"Total balance in {bank.BankName} is {accounts[bank]} ");
		}
		else
		{
			Console.WriteLine($"No Opened account in this Bank .");
		}
	}
}

// Bank Class
public class Bank
{
    public string BankName { get; private set; }

    public Bank(string bankName)
    {
        BankName = bankName;
    }

	// Method to Open Account
    public void OpenAccount(Customer customer, double initialBalance)
    {
        customer.AddAccount(this, initialBalance);
        Console.WriteLine($"Account opened for {customer.name} in {BankName}");
    }
}

