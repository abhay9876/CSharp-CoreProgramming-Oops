/*Person Class (Copy Constructor)
o Create a Person class with a copy constructor that clones another person's
attributes.*/



using System;

public class Person
{
	string name;
	int age;


	// Parameterized Constructor
    public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	// Copy Constructor
	public Person(Person other)
	{
		this.name = other.name;
		this.age = other.age;
	}


	public void Display()
	{
		Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age : {age}");
    }
}
