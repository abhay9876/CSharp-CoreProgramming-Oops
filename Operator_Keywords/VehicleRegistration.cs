/*Vehicle Registration System
Create a Vehicle class with the following features:
● static:
o A static variable RegistrationFee common for all vehicles.

o A static method UpdateRegistrationFee() to modify the fee.
● this:
o Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the
constructor.
● readonly:
o Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
● is operator:
o Check if an object belongs to the Vehicle class before displaying its
registration details.*/


using System;

public class Vehicle
{
	// static variable
	public static double registrationFee = 1500;

	string ownerName;
	string vehicleType;
	readonly string registrationNumber;

	public Vehicle(string ownerName, string vehicleType, string registrationNumber)
	{
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
		this.registrationNumber = registrationNumber;
	}

    // static method to update registration Fee
    public static void UpdateRegistrationFee(double fee)
	{
		
		registrationFee = fee;
        

    }

    public void DisplayDetails()
    {
        Console.WriteLine($" Owner Name  : {ownerName}");
        Console.WriteLine($" Vehicle Type : {vehicleType}");
        Console.WriteLine($" Registration Number : {registrationNumber}");
		
    }
}

public class VehicleRegistration
{
	public static void Run()
	{
		Console.WriteLine("Welcome To Vehicle Registration ...");
		Console.WriteLine("Enter the Owner's name : ");
		string name = Console.ReadLine();
		Console.WriteLine("Enter the type of Vehicle :");
        string type = Console.ReadLine();
        Console.WriteLine("Enter Registration Number :");
        string number = Console.ReadLine();


        // object reference for is-operator check
        object obj = new Vehicle(name, type, number);

        // is operator validation
        if (obj is Vehicle vehicle)
        {
            vehicle.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Invalid Vehicle object.");
        }

    }
}
