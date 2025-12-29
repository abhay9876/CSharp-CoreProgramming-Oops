/*Employee Records
● Develop an Employee class with:
o employeeID (public)
o department (protected)
o salary (private)
● Implement methods to:

o Modify salary using a public method.
o Create a subclass Manager to access employeeID and department.*/





using System;

public class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    // Constructor
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary =salary;
    }

    // Public Method for Access Salary
    public double GetSalary()
    {
        return salary;
    }

    // Modify the Salary
    public void SetSalary(double salary)
    {
        this.salary = salary;
    }
}

// Sub Class
public class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary)
    {
        
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID  :  {employeeID}");
        Console.WriteLine($"Department  :  {department}");
        Console.WriteLine($"Salary :  {GetSalary()}");
        

    }
}


