/*Library Book System
o Create a Book class with attributes title, author, price, and availability.
o Implement a method BorrowBook() to borrow a book.*/



using System;

public class Book
{
    // Attributes
    private string title;
    private string author;
    private double price;
    private bool available;

    //Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = true; 
    }

    //Method to borrow a book
    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine($"You have successfully borrowed '{title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{title}' is currently not available.");
        }
    }

    
}
