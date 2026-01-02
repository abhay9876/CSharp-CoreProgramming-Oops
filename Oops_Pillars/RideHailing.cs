/*Ride-Hailing Application
Description: Develop a ride-hailing application.
● Abstract Class:
o Define an abstract class Vehicle with fields: vehicleId, driverName, and
ratePerKm.
o Add an abstract method CalculateFare(double distance).
o Implement a concrete method GetVehicleDetails().
● Subclasses:
o Extend Vehicle into Car, Bike, and Auto.
o Override CalculateFare() based on type-specific rates.
● Interface:
o Implement an interface IGPS.
o Define methods GetCurrentLocation() and UpdateLocation().
● Encapsulation:
o Secure driver and vehicle details using private fields and properties.

● Polymorphism:
o Create a method that processes multiple vehicle types dynamically.
o Calculate fares based on the Vehicle reference.*/




using System;

// Abstract class
public abstract class Vehicle
{
    // Encapsulation
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    // Constructor
    public Vehicle(int id, string driverName, double ratePerKm)
    {
        this.vehicleId = id;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }
    public int VehicleId
    {
        get { return vehicleId; }
    }

    public string DriverName
    {
        get { return driverName; }
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // non-abstract method
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
    }
}

// Interface
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}


// Car class
public class Car : Vehicle, IGPS
{
    private string location;

    public Car(int id, string driverName)
        : base(id, driverName, 20)  
    {
    }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}

// Bike class
public class Bike : Vehicle, IGPS
{
    private string location;

    public Bike(int id, string driverName)
        : base(id, driverName, 12) {    
    }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}

// Auto class
public class Auto : Vehicle
{
    public Auto(int id, string driverName)
        : base(id, driverName, 10)  
    {
    }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }
}




