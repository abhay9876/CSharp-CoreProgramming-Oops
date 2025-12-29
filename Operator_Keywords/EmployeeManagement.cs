/*Employee Management System
Design an Employee class with the following features:
● static:
o A static variable CompanyName shared by all employees.
o A static method DisplayTotalEmployees() to show the total number of
employees.

● this:
o Use this to initialize Name, Id, and Designation in the constructor.
● readonly:
o Use a readonly variable Id for the employee ID, which cannot be modified
after assignment.

● is operator:
o Check if a given object is an instance of the Employee class before printing
the employee details.*/



using System;

public class Employee
{
    public string name;
    public readonly string id;
    public string designation;

    public static string companyName = "Microsoft";
    public static int employee = 0;
    

    //Constructor
    public Employee(string name, string id, string designation)
    {
        this.name = name;
        this.id = id;
        this.designation = designation;
        employee++;
    }

    //Get Company Name
    public static string GetCompanyName()
    {
        return companyName;
    }

    public static int GetEmployees()
    {
        return employee;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Employee Name : {name}");
        Console.WriteLine($"Employee ID : {id}");
        Console.WriteLine($"Designation : {designation}");
    }
}

public class EmployeeManagement
{
    public static void Run()
    {
        Console.WriteLine($"Welcome to  {Employee.GetCompanyName()}");
        Console.WriteLine("Enter the Employee Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Employee id : ");
        string id = Console.ReadLine();
        Console.WriteLine("Enter the Designation : ");
        string designation = Console.ReadLine();

        // New Object for Comparison
        object obj = new Employee(name, id , designation);

        if (obj is Employee obj2)
        {
            obj2.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Object is not a valid Employee Instance...");
        }

        Console.WriteLine("Total Employees are : " + Employee.GetEmployees());

    }
}

