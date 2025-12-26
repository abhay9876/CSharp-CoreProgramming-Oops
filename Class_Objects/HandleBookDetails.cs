/*Program to Handle Book Details
Problem Statement: Write a program to create a Book class with attributes title, author, and
price. Add a method to display the book details.*/



using System;

public class HandleBookDetails
{
    //Fields (Attributes)
    string title;
    string author;
    int price;

    //Constructor
    public HandleBookDetails(string title, string author, int price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }


    //Display Book Details
    public void BookDetails()
    {
        Console.WriteLine("Book Details : ");
        Console.WriteLine(" Title : " + title);
        Console.WriteLine(" Author  : " + author);
        Console.WriteLine(" Price : " + price);

    }
}
