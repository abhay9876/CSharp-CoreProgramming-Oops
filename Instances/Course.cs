/*Online Course Management
● Design a Course class with:
o Instance Variables: courseName, duration, fee.
o Class Variable: instituteName (common for all courses).
● Implement the following methods:
o An instance method DisplayCourseDetails() to display course details.
o A class method UpdateInstituteName() to modify the institute name for all
courses.*/


using System;

public class Course
{
    // Instance variables
    string courseName;
    int duration;      
    double fee;

    // Class variable
    static string instituteName = "BridgeLabz";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute   : {instituteName}");
        Console.WriteLine($"Course Name : {courseName}");
        Console.WriteLine($"Duration    : {duration} weeks");
        Console.WriteLine($"Fee         : {fee}");
        Console.WriteLine("-------------------------------");
    }

    // Class method
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}
