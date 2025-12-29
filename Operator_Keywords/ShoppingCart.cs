/*Shopping Cart System
Create a Product class to manage shopping cart items with the following features:
● static:
o A static variable Discount shared by all products.

o A static method UpdateDiscount() to modify the discount percentage.
● this:
o Use this to initialize ProductName, Price, and Quantity in the constructor.
● readonly:
o Use a readonly variable ProductID to ensure each product has a unique
identifier that cannot be changed.

● is operator:
o Validate whether an object is an instance of the Product class before
processing its details.*/


using System;

public class Product
{
    public string productName;
    public int quantity;
    public decimal price;
    // readonly
    public readonly string productId;

    // static
    public static decimal discount = 0; 
    public static int totalProducts = 0;

    // Constructor
    public Product(string productName, string productId, int quantity, decimal price)
    {
        this.productName = productName;
        this.productId = productId;
        this.quantity = quantity;
        this.price = price;

        totalProducts++;
    }

    // static method to update discount
    public static void UpdateDiscount(decimal newDiscount)
    {
        discount = newDiscount;
    }

    public static int GetTotalProducts()
    {
        return totalProducts;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Product Name : {productName}");
        Console.WriteLine($"Product ID   : {productId}");
        Console.WriteLine($"Quantity     : {quantity}");
        Console.WriteLine($"Price        : {price}");

        decimal total = price * quantity;
        decimal finalPrice = total - (total * discount / 100);

        Console.WriteLine($"Final Price after {discount}% discount : {finalPrice}");
    }
}

public class ShoppingCart
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Shopping Cart System");

        Console.Write("Enter Product Name : ");
        string name = Console.ReadLine();

        Console.Write("Enter Product ID : ");
        string id = Console.ReadLine();

        Console.Write("Enter Quantity : ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter Price : ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Discount : ");
        decimal discount = decimal.Parse(Console.ReadLine());

        // update static discount
        Product.UpdateDiscount(discount);

        // object reference for is-operator check
        object obj = new Product(name, id, quantity, price);

        // is operator validation
        if (obj is Product product)
        {
            product.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Invalid Product object.");
        }

        Console.WriteLine("Total Products in Cart : " + Product.GetTotalProducts());
    }
}

