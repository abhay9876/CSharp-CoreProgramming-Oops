/*Library Management System
Description: Develop a library management system:
● Use an abstract class LibraryItem with fields like itemId, title, and author.
● Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
● Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with
specific logic.
● Implement an interface IReservable with methods ReserveItem() and
CheckAvailability().
● Apply encapsulation to secure details like the borrower’s personal data.
● Use polymorphism to allow a general LibraryItem reference to manage all items.*/


using System;

// Abstract class
public abstract class LibraryItem
{
    // Encapsulation
    private int itemId;
    private string title;
    private string author;

    // Constructor
    public LibraryItem(int id, string title, string author)
    {
        this.itemId = id;
        this.title = title;
        this.author = author;
    }

    public int ItemId
    {
        get { return itemId; }
    }

    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    // Abstract method
    public abstract int GetLoanDuration();

    // non-abstract method
    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

// Interface
public interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book class
public class Book : LibraryItem, IReservable
{
    private string borrowerName;

    public Book(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 10;
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book reserve successfully");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}

// Magazine class
public class Magazine : LibraryItem
{
    public Magazine(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 5; 
    }
}

// DVD class
public class DVD : LibraryItem, IReservable
{
    private string borrowerContact;

    public DVD(int id, string title, string author)
        : base(id, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 2; 
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD reserve successfully");
    }

    public bool CheckAvailability()
    {
        return true;
    }
}



