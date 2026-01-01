/*Company and Departments (Composition)
Description: A Company has several Department objects, and each department contains
Employee objects. Model this using composition, where deleting a Company should also
delete all departments and employees.
Tasks:

● Define a Company class that contains multiple Department objects.
● Define an Employee class within each Department.
● Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and
Employee objects cannot exist without a Company.*/


using System;



// Company Class
internal  class Company
{
    public string CompanyName { get; }
    private List<Department> departments = new List<Department>();

    public Company(string companyName)
    {
        CompanyName = companyName;
    }

    public void AddDepartment(string deptName)
    {
        // Composition between Company and Department
        departments.Add(new Department(deptName));
    }
    public Department GetDepartment(string deptName)
    {
        foreach (Department dept in departments)
        {
            if (dept.dept_name == deptName)
            {
                return dept;
            }
        }
        return null;
    }


    public void ShowCompanyDetails()
    {
        Console.WriteLine($"Company: {CompanyName}");
        foreach (var dept in departments)
        {
            dept.ShowEmployees();
        }
    }
}


// Department Classs
public class Department
{
	public string dept_name;
	List<Employee> list = new List<Employee>();

	public Department(string dept_name)
	{
		this.dept_name = dept_name;
	}

	public void AddEmployee(string emp)
	{
        // Creating Objects of Employee from department class
		list.Add(new Employee(emp));
	}

    public void ShowEmployees()
    {
        Console.WriteLine($"Department: {dept_name}");
        foreach (var emp in list)
        {
            Console.WriteLine($" - {emp.name}");
        }
    }
}

//Employee Class
public class Employee
{
	public string name;
	

	public Employee(string name)
	{
		this.name = name;
		
	}
	
}

