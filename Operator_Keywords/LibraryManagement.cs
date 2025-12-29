/*Library Management System
Create a Book class to manage library books with the following features:
● static:
o A static variable LibraryName shared across all books.

o A static method DisplayLibraryName() to print the library name.
● this:
o Use this to initialize Title, Author, and ISBN in the constructor.
● readonly:
o Use a readonly variable ISBN to ensure the unique identifier of a book cannot
be changed.
● is operator:
o Verify if an object is an instance of the Book class before displaying its details.*/




using System;

public class Library
{
	public static string libraryname="Zeno'sLibrary";


	public string title;
	public string author;
	public readonly string ISBN;

	public Library(string title , string author, string ISBN)
	{
		this.title = title;
		this.author = author;
		this.ISBN = ISBN;
	}

	public static string GetName()
	{
		return libraryname;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"Title : {title}");
        Console.WriteLine($"Author : {author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }
}

public class LibraryManagement
{
	public static void Run()
	{
		Console.WriteLine($"Welcome to {Library.GetName()}");
		Console.WriteLine("Enter the Title : ");
		string title = Console.ReadLine();
		Console.WriteLine("Enter the Author : ");
		string author = Console.ReadLine();
		Console.WriteLine("Enter ISBN : ");
		string ISBN = Console.ReadLine();

		object obj = new Library(title, author, ISBN);
		if (obj is Library obj2)
		{

			obj2.DisplayDetails();
		}

		else
		{
			Console.WriteLine("Object is not a valid Library Instance...");
		}

	}
}
