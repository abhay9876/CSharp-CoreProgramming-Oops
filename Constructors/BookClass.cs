/*Book Class
o Create a Book class with attributes title, author, and price.
o Provide both default and parameterized constructors.*/


using System;

public class BookClass
{
	string title;
	string author;
	int price;

	public BookClass()
	{
		title = "The War";
		author = "Zeno";
		price = 250000;
	}

	public BookClass(string title, string author , int price)
	{
		this.title = title;
		this.author = author;
		this.price = price;
	}


	public void Display()
	{
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine("--------------------");
    }
	
}
