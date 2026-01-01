/*Educational Course Hierarchy

○ Description: Model a course system where Course is the base class,
OnlineCourse is a subclass, and PaidOnlineCourse extends
OnlineCourse.
○ Tasks:
■ Define a superclass Course with attributes like CourseName and
Duration.
■ Define OnlineCourse to add attributes such as Platform and
IsRecorded.
■ Define PaidOnlineCourse to add Fee and Discount.
○ Goal: Demonstrate how each level of inheritance builds on the previous, adding
complexity to the system.*/




using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
    // Virtual method
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course Details:");
        Console.WriteLine($"Name  : {CourseName}");
        Console.WriteLine($"Duration : {Duration} hours");
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName,int duration, string platform,bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Platform  : {Platform}");
        Console.WriteLine($"Recorded  : {IsRecorded}");
    }
}

//paid online courses
class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } 

    public PaidOnlineCourse( string courseName, int duration, string platform, bool isRecorded, double fee,double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Fee  : {Fee}");
        Console.WriteLine($"Discount  : {Discount}%");
        Console.WriteLine($"Final Fee : {Fee - (Fee * Discount / 100)}");
    }
}



