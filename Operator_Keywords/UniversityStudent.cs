/*University Student Management
Create a Student class to manage student data with the following features:
● static:
o A static variable UniversityName shared across all students.
o A static method DisplayTotalStudents() to show the number of students
enrolled.

● this:
o Use this in the constructor to initialize Name, RollNumber, and Grade.
● readonly:
o Use a readonly variable RollNumber for each student that cannot be changed.
● is operator:
o Check if a given object is an instance of the Student class before performing
operations like displaying or updating grades.*/

using System;

public class Student
{
	//static variable
	public static string universityName ="GLA UNIVERSITY";
	public static int studentNumber = 0;

	// Instance Variable
	string name;
	readonly int rollNo;
	char grade;

	// Constructor
	public Student(string name , int rollNo , char grade)
	{
		this.name = name;
		this.rollNo = rollNo;
		this.grade = grade;
		studentNumber++;
	}


    // static method to Display the number of students
    public static int DisplayTotalStudents()
	{
		return studentNumber;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($" Name : {name}");
		Console.WriteLine($" roll No. : {rollNo}");
		Console.WriteLine($" Grade : {grade}");
	}
}

public class University
{
	public static void Run()
	{
		Console.WriteLine($"WelCome to {Student.universityName}");
		Console.WriteLine("Enter the student's name : ");
		string name = Console.ReadLine();
        Console.WriteLine("Enter the Roll No.  : ");
        int rollNo= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Grade : ");
        char grade = Console.ReadLine()[0];

        // object reference for is-operator check
        object obj = new Student(name, rollNo, grade);

        // is operator validation
        if (obj is Student student)
        {
            student.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Invalid Student object.");
        }

		Console.WriteLine("Total Students in University : " + Student.DisplayTotalStudents());
    }
	
}