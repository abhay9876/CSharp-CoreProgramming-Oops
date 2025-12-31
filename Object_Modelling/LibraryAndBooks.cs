/*Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the
relationship such that a library can have many books, but a book can exist independently
(outside of a specific library).
Tasks:
● Define a Library class with a List<Book> collection.
● Define a Book class with attributes such as Title and Author.
● Demonstrate the aggregation relationship by creating books and adding them to
different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library
aggregates Book objects.*/


using System;

//Book Class
public class Book
{
	public string title;
	public string author;
    
	public Book(string title, string author)
	{
		this.author = author;
		this.title = title;
	}
}

// Library Class 
public class Library
{
	public string library_name;
	public List<Book> list;
	public Library(string library_name)
	{
		this.library_name = library_name;
		list = new List<Book>();

	}


	public void AddBook(Book book)
	{
		list.Add(book);
	}
	public void RemoveBook(Book book)
	{
		list.Remove(book);
	}

	public void BookDetails()
	{
		Console.WriteLine($"------{library_name}-------");
		foreach(var book in list)
		{
			Console.WriteLine($" Name : {book.title}");
            Console.WriteLine($" Author : {book.author}");
            Console.WriteLine();
        }
        Console.WriteLine($"-----------------------");

    }
}
