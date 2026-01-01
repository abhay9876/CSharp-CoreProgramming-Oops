/*Problem 2: University with Faculties and Departments (Composition and
Aggregation)
Description: Create a University with multiple Faculty members and Department objects.
Model it so that the University and its Departments are in a composition relationship
(deleting a university deletes all departments), and the Faculty members are in an
aggregation relationship (faculty can exist outside of any specific department).
Tasks:
● Define a University class with Department and Faculty classes.
● Demonstrate how deleting a University also deletes its Departments.
● Show that Faculty members can exist independently of a Department.

Goal: Understand the differences between composition and aggregation in modeling
complex hierarchical relationships.*/






using System;

// University Class
class University
{
    public string UniversityName { get; }

    private List<Department1> departments = new();

    public University(string name)
    {
        UniversityName = name;
    }

    // Composition University creates Department
    public void AddDepartment(string deptName)
    {
        departments.Add(new Department1(deptName));
    }

    public Department1 GetDepartment(string deptName)
    {
        foreach (Department1 dept in departments)
        {
            if (dept.DepartmentName == deptName)
            {
                return dept;
            }
        }
        return null;
    }
}


// DEpartment class
class Department1
{
    public string DepartmentName { get; }

    private List<Faculty> faculties = new();

    public Department1(string name)
    {
        DepartmentName = name;
    }

    // Aggregation Faculty comes from outside
    public void AddFaculty(Faculty faculty)
    {
        faculties.Add(faculty);
    }
}


// Faculty class
public class Faculty
{
    public string Name { get; }

    public Faculty(string name)
    {
        Name = name;
    }
}

