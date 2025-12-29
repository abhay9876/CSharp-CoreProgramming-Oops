/*Problem 1: University Management System
● Create a Student class with:
o rollNumber (public)
o name (protected)
o CGPA (private)

● Implement methods to:
o Access and modify CGPA using public methods.
o Create a subclass PostgraduateStudent to demonstrate the use of protected
members.*/



using System;

public class Student
{
	public int rollNo;
	protected string name;
	private double CGPA;

	//Constructor
	public Student(int rollNo , string name,double CGPA)
	{
		this.rollNo = rollNo;
		this.name = name;
		this.CGPA = CGPA;
	}

	// Public Method for Access CGPA
	public double GetCGPA()
	{
		return CGPA;
	}

	// Modify the CGPA
	public void SetCGPA(double CGPA)
	{
		if(CGPA > 0  && CGPA <= 10)
		{
			this.CGPA = CGPA;
		}
		else
		{
			Console.WriteLine("Invalid CGPA input");
		}
	}
}

// Sub Class
public class PostgraduateStudent : Student
{
	public string course;

	public PostgraduateStudent(int rollNo,string name,double CGPA,string course) : base(rollNo, name, CGPA)
	{
		this.course = course;
	}


	public void DisplayDetails()
	{
		Console.WriteLine($"Roll No. : {rollNo}");
        Console.WriteLine($"Name  : {name}");
        Console.WriteLine($"CGPA : {GetCGPA()}");
        Console.WriteLine($"Course : {course}");
    }
}