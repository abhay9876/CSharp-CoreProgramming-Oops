/*Instance vs. Class Variables and Methods
Problem 1: Product Inventory
● Create a Product class with:
o Instance Variables: productName, price.
o Class Variable: totalProducts (shared among all products).

● Implement the following methods:
o An instance method DisplayProductDetails() to display the details of a
product.
o A class method DisplayTotalProducts() to show the total number of
products created.*/


using System;

public class Product
{
    // Instance variables
    string productName;
    double price;

    //Class variable
    static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name : {productName}");
        Console.WriteLine($"Price        : {price}");
        Console.WriteLine("---------------------------");
    }

    // Class method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products Created: {totalProducts}");
    }
}
