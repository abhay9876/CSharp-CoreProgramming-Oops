/*Circle Class
o Write a Circle class with a radius attribute.
o Use constructor chaining to initialize radius with both default and
user-provided values.*/

using System;

public class CircleClass
{
    //Fields (Attributes)
    double radius;

    // Default Constructor
    public CircleClass() : this(2.0)
    {
        
    }

    // Parameterized Constructor
    public CircleClass(double radius)
    {
        this.radius = radius;
    }


    public void Display()
    {
        Console.WriteLine($"The radius is : {radius}");
    }
}
