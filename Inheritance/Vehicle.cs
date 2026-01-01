/*Vehicle Management System with Hybrid Inheritance
○ Description: Model a vehicle system where Vehicle is the superclass and
ElectricVehicle and PetrolVehicle are subclasses. Additionally, create a
Refuelable interface implemented by PetrolVehicle.
○ Tasks:

■ Define a superclass Vehicle with attributes like MaxSpeed and Model.
■ Create an interface Refuelable with a method Refuel().
■ Define subclasses ElectricVehicle and PetrolVehicle.
PetrolVehicle should implement Refuelable, while
ElectricVehicle include a Charge() method.

○ Goal: Use hybrid inheritance by having PetrolVehicle implement both
Vehicle and Refuelable, demonstrating how Java interfaces allow adding
multiple behaviors.*/



class Vehicle1
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle1(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model : {Model}");
        Console.WriteLine($"Max Speed : {MaxSpeed} km/h");
    }
}

// Interface 
interface Refuelable
{
    void Refuel();
}


// Electric Vehicles Class
class ElectricVehicle : Vehicle1
{
    public ElectricVehicle(string model, int maxSpeed)
        : base(model, maxSpeed)
    {
    }

    public void Charge()
    {
        Console.WriteLine($"Electric vehicle {Model} is charging.");
    }
}


class PetrolVehicle : Vehicle1, Refuelable
{
    public PetrolVehicle(string model, int maxSpeed)
        : base(model, maxSpeed)
    {
    }

    public void Refuel()
    {
        Console.WriteLine($"Petrol vehicle {Model} is being refueled.");
    }


}
