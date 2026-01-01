/*School System with Different Roles

○ Description: Create a hierarchy for a school system where Person is the
superclass, and Teacher, Student, and Staff are subclasses.

○ Tasks:
■ Define a superclass Person with common attributes like Name and Age.
■ Define subclasses Teacher, Student, and Staff with specific
attributes (e.g., Subject for Teacher and Grade for Student).
■ Each subclass should have a method like DisplayRole() that
describes the role.

○ Goal: Demonstrate hierarchical inheritance by modeling different roles in a
school, each with shared and unique characteristics.*/


using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method for role description
    public virtual void DisplayRole()
    {
        Console.WriteLine("Role: Person");
    }
}

// Teacher class
class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine($"Subject: {Subject}");
    }
}


// Student Class
class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine($"Grade: {Grade}");
    }
}

// Staff Class

class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine($"Department: {Department}");
    }
}


