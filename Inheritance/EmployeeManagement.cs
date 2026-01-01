/*Employee Management System
Description:
Create an Employee hierarchy for different employee types such as Manager, Developer, and
Intern.
Tasks:
1. Define a base class Employee:
o Add three attributes: Name (string), Id (integer), and Salary (double).
o Add a method DisplayDetails() to display the details of an employee.
2. Define subclasses Manager, Developer, and Intern:
o Manager: Add an additional attribute TeamSize (integer).
o Developer: Add an additional attribute ProgrammingLanguage (string).
o Intern: Add an additional attribute InternshipDuration (string).
3. Goal:
o Practice inheritance by creating subclasses with specific attributes and
overriding superclass methods (e.g., DisplayDetails()) to display details specific
to each type of employee*/


using System;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method 
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Details :  ");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Salary : {Salary}");
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager ( string name , int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }
    //Override method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size : {TeamSize}");
        Console.WriteLine("Role  : Manager");
    }
}

// Developer Class
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Language  : {ProgrammingLanguage}");
        Console.WriteLine("Role  : Developer");
    }
}

//Intern Class
class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        InternshipDuration = duration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Duration  : {InternshipDuration}");
        Console.WriteLine("Role   : Intern");
    }
}
