/*School and Students with Courses (Association and Aggregation)
Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
Tasks:
● Define School, Student, and Course classes.
● Model an association between Student and Course to show that students can enroll
in multiple courses.
● Model an aggregation relationship between School and Student.
● Demonstrate how a student can view the courses they are enrolled in and how a
course can show its enrolled students.
Goal: Practice association by modeling many-to-many relationships between students and
courses.*/



using System;


public class School
{
	public string name;
	List<Student> listOfStudents;

	public School(string name)
	{
		this.name = name;
        listOfStudents= new List<Student>();
    }

	public void AddStudents(Student student)
	{
		listOfStudents.Add(student);
	}

	public void StudentDetails(Student student)
	{
		Console.WriteLine($"{student.name}");
		student.ViewCourses();
	}

}

public class Student
{
	public string name;
	List<Course> courses = new List<Course>();

	public Student(string name)
	{
		this.name = name;
	}

	public void AddCourse(Course course)
	{
		courses.Add(course);
	}

	public void ViewCourses()
	{
		Console.WriteLine("Courses-----");
		foreach(var list in courses)
		{
			Console.WriteLine(list);
		}
	}


}

public class Course
{
	public string course_name;
	List<Student> enroll = new List<Student>();

	public Course(string course_name)
	{
		this.course_name = course_name;
	}

	public void Enrolled(Student student)
	{
		enroll.Add(student);
		Console.WriteLine($"{student.name} has enrolled in {course_name}");
	}

	public void EnrolledStudents()
	{
        Console.WriteLine($"Enrolled Student for {course_name}-----");
        foreach (var list in enroll)
        {
            Console.WriteLine(list.name);
        }
    }
}
