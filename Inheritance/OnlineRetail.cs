/*Online Retail Order Management

○ Description: Create a multilevel hierarchy to manage orders, where Order is
the base class, ShippedOrder is a subclass, and DeliveredOrder extends
ShippedOrder.
○ Tasks:
■ Define a base class Order with common attributes like orderId and
OrderDate.
■ Create a subclass ShippedOrder with additional attributes like
TrackingNumber.
■ Create another subclass DeliveredOrder extending ShippedOrder,
adding a DeliveryDate attribute.
■ Implement a method GetOrderStatus() to return the current order
status based on the class level.

○ Goal: Explore multilevel inheritance, showing how attributes and methods can be
added across a chain of classes.*/

using System;

class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    // Virtual method for multilevel polymorphism
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

// Shipped order Class
class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

// Delivered order Class

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder( int orderId,DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}


