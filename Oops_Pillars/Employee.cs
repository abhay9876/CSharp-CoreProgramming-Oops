/*Employee Management System
Description: Build an employee management system with the following requirements:
● Use an abstract class Employee with fields like employeeId, name, and baseSalary.
● Provide an abstract method CalculateSalary() and a concrete method
DisplayDetails().
● Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing
CalculateSalary() based on work hours or fixed salary.
● Use encapsulation to restrict direct access to fields and provide properties for access.
● Create an interface IDepartment with methods like AssignDepartment() and
GetDepartmentDetails().
● Ensure polymorphism by processing a list of employees and displaying their details
using the Employee reference.*/


using System;

public abstract class Employee
{
    private int employeeID;
    private string name;
    protected int baseSalary;

    public Employee(int employeeID, string name, int baseSalary) { 
        this.employeeID = employeeID;
        this.name= name;
        this.baseSalary = baseSalary;
        }

    public int GetEmployeeId
    {
        get
        {
            return employeeID;
        }
        set
        {
            employeeID = value;
        }
    }

    public string GetName
    {
        get { return name; }
        set { name = value; }
    }

    public abstract int CalculateSalary();
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Id : " + GetEmployeeId);
        Console.WriteLine("Name : " + GetName);
        Console.WriteLine("Salary : " + CalculateSalary());
    }
}

//Interface
public interface IDepartment
{
    void AssignDepartment(string dept_name);
    string GetDepartmentDetails();
}


// Full Time Employee Class
public class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id,string name,int fixedSalary)
        : base(id, name, fixedSalary)
    {
    }

    public override int CalculateSalary()
    {
        return baseSalary;
    }

    public void AssignDepartment(string dept_name)
    {
        department = dept_name;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

// Part Time Employee Class
public class PartTimeEmployee : Employee, IDepartment
{
    private int workHours;
    private string department;

    public PartTimeEmployee(int id, string name, int hourlyRate, int workHours)
        : base(id, name, hourlyRate)
    {
        this.workHours = workHours;
    }

    public override int CalculateSalary()
    {
        return baseSalary * workHours;
    }

    public void AssignDepartment(string dept_name)
    {
        department = dept_name;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
