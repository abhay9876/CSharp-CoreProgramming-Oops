/*Vehicle and Transport System
Description:
Design a vehicle hierarchy where Vehicle is the superclass, and Car, Truck, and Motorcycle
are subclasses with unique attributes.
Tasks:

1. Define a superclass Vehicle:
o Add two attributes: MaxSpeed (integer) and FuelType (string).
o Add a method DisplayInfo() to display the vehicle's
information.

2. Define subclasses Car, Truck, and Motorcycle that inherit from
Vehicle:
o Car: Add an additional attribute SeatCapacity (integer).
o Truck: Add an additional attribute PayloadCapacity (integer).
o Motorcycle: Add an additional attribute HasSidecar (boolean).
3. Demonstrate polymorphism:
o Store objects of type Car, Truck, and Motorcycle in an array of
Vehicle type.
o Call the DisplayInfo() method on each object in the array and
observe dynamic method dispatch.

Goal: Understand how inheritance helps in organizing shared and unique features across
subclasses and use polymorphism for dynamic method calls.*/



using System;

public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method 
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle Information:");
        Console.WriteLine($"Max Speed : {MaxSpeed} ");
        Console.WriteLine($"Fuel Type : {FuelType}");
    }
}

// Car Class
class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity : {SeatCapacity}");
        Console.WriteLine("Type  : Car");
    }
}


//Truck Class
class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Payload       : {PayloadCapacity} kg");
        Console.WriteLine("Type  : Truck");
    }
}

// Motorcycle Class
class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar   : {HasSidecar}");
        Console.WriteLine("Type  : Motorcycle");
    }
}



