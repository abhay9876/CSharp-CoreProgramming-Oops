/*E-Commerce Platform
Description: Develop a simplified e-commerce platform:
● Create an abstract class Product with fields like productId, name, and price, and an
abstract method CalculateDiscount().
● Extend it into concrete classes: Electronics, Clothing, and Groceries.
● Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for
applicable product categories.
● Use encapsulation to protect product details, allowing updates only through setter
methods.
● Showcase polymorphism by creating a method that calculates and prints the final price
(price + tax - discount) for a list of products.*/



using System;

// Abstract Class Product 
public abstract class Product
{
    private int productID;
    private string name;
    private double price;

    // Constructor
    public Product(int productID, string name , double price)
    {
        this.productID = productID;
        this.name = name;
        this.price = price;
    }


    public int GetProductId
    {
        get { return productID; }
        set { productID = value; }
    }
    public string GetName
    {
        get { return name; }
        set { name = value; }
    }

    public double GetPrice
    {
        get { return price; }
        protected set { price = value; }
    }


    public abstract double CalculateDiscount();

}


// Interface
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics Class
public class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return GetPrice * 0.10; 
    }

    public double CalculateTax()
    {
        return GetPrice * 0.18; 
    }

    public string GetTaxDetails()
    {
        return "18% GST on Electronics";
    }
}

public class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return GetPrice * 0.15;
    }

    public double CalculateTax()
    {
        return GetPrice * 0.02; 
    }

    public string GetTaxDetails()
    {
        return "2% GST on Clothing";
    }
}

public class Groceries : Product, ITaxable
{
    public Groceries(int id, string name, double price)
        : base(id, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return GetPrice * 0.05;
    }

    public double CalculateTax()
    {
        return GetPrice * 0.01;
    }

    public string GetTaxDetails()
    {
        return "1% GST on Clothing";
    }


}





