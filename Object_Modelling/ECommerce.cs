/*Problem 4: E-commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.
Model relationships where a Customer places an Order, and each Order contains multiple
Product objects.
Goal: Show communication and object relationships by designing a system where customers
communicate through orders, and orders aggregate products.*/



using System;

class Order
{
    public int OrderId { get; }
    private List<Product> products = new List<Product>();

    public Order(int orderId)
    {
        OrderId = orderId;
    }

    // Aggregation Product comes from outside
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        double total = 0;

        foreach (var p in products)
        {
            Console.WriteLine($" - {p.Name} : ₹{p.Price}");
            total += p.Price;
        }

        Console.WriteLine($"Total Amount: ₹{total}");
    }
}
class Product
{
    public string Name { get; }
    public double Price { get; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class Customer
{
    public string Name { get; }

    public Customer(string name)
    {
        Name = name;
    }

    // Communication method
    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"Customer {Name} placed Order ID {order.OrderId}");
        order.ShowOrderDetails();
    }
}
