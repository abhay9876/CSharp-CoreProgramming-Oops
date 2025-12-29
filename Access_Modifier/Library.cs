/*Book Library System
● Design a Book class with:
o ISBN (public)
o title (protected)
o author (private)
● Implement methods to:
o Set and get the author name.
o Create a subclass EBook to access ISBN and title and demonstrate access
modifiers.*/




using System;

public class Book
{
	public int ISBN;
	protected string title;
	private string author;

     // Constructor
	public Book(int ISBN, string title , string author)
	{
		this.ISBN = ISBN;
		this.title = title;
		this.author = author;
	}

    // Public Method for Access Author name
    public string GetAuthor()
	{
		return author;
	}

	// Modify the author name
	public void SetAuthor(string author)
	{
		this.author=author;
	}
}

// Sub Class
public class Ebook : Book
{
	string mode;

	public Ebook(int ISBN,string title , string author , string mode) : base(ISBN , title , author)
	{
		this.mode = mode;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"ISBN  :  {ISBN}");
        Console.WriteLine($"Title  :  {title}");
        Console.WriteLine($"author :  {GetAuthor()}");
        Console.WriteLine($"Mode  :  {mode}");

    }
}
