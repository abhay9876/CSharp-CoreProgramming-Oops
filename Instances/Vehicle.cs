/*Vehicle Registration
● Create a Vehicle class to manage vehicle details:
o Instance Variables: ownerName, vehicleType.
o Class Variable: registrationFee (fixed for all vehicles).
● Implement the following methods:
o An instance method DisplayVehicleDetails() to display owner and vehicle
details.
o A class method UpdateRegistrationFee() to change the registration fee.*/


using System;

public class Vehicle
{
    // Instance variables
    string ownerName;
    string vehicleType;

    // Class variable 
    private static double registrationFee = 5000.0;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name        : {ownerName}");
        Console.WriteLine($"Vehicle Type      : {vehicleType}");
        Console.WriteLine($"Registration Fee  : {registrationFee}");
        Console.WriteLine("--------------------------------------");
    }

    // Class method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}
