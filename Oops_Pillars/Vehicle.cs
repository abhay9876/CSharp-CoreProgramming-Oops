/*Vehicle Rental System
Description: Design a system to manage vehicle rentals:
● Define an abstract class Vehicle with fields like vehicleNumber, type, and rentalRate.
● Add an abstract method CalculateRentalCost(int days).
● Create subclasses Car, Bike, and Truck with specific implementations of
CalculateRentalCost().
● Use an interface IInsurable with methods CalculateInsurance() and
GetInsuranceDetails().
● Apply encapsulation to restrict access to sensitive details like insurance policy
numbers.
● Demonstrate polymorphism by iterating over a list of vehicles and calculating rental and
insurance costs for each.*/



using System;

// abstract Class 
public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    protected double rentalRate;

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    // Encapsulation
    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }

    public string Type
    {
        get { return type; }
    }

    // Abstract method
    public abstract double CalculateRentalCost(int days);
}


// Interface
public interface IInsurable
{
    double CalculateInsurance(int days);
    string GetInsuranceDetails();
}



// Car Class
public class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(string number, double rate, string policyNumber)
        : base(number, "Car", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance(int days)
    {
        return 200 * days;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance......";
    }
}




// Bike Class
public class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Bike(string number, double rate, string policyNumber)
        : base(number, "Bike", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return (rentalRate * days) - 100;
    }

    public double CalculateInsurance(int days)
    {
        return 100 * days;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance ....";
    }
}


// truck class
public class Truck : Vehicle
{
    public Truck(string number, double rate)
        : base(number, "Truck", rate)
    {
    }

    public override double CalculateRentalCost(int days)
    {
        return (rentalRate * days) + 500; 
    }
}
