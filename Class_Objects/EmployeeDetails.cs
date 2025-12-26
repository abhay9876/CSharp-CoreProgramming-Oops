/*Program to Display Employee Details
Problem Statement: Write a program to create an Employee class with attributes name, id,
and salary. Add a method to display the details.*/


using System;

public class EmployeeDetails
{
    // Fields (Attributes)
    string name;
    int id;
    int salary;

    // Constructor
    public EmployeeDetails(string name, int id, int salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    //Method to display Employee Details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("id : " + id);
        Console.WriteLine("Salary : " + salary);
    }
   	
}
