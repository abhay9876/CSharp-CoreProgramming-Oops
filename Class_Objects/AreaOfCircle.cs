/*Program to Compute Area of a Circle
Problem Statement: Write a program to create a Circle class with an attribute radius. Add*/


using System;

public class AreaOfCircle
{
	//Fields (Attributes)
	double radius;

	//Constructor
	public AreaOfCircle(double radius)
	{
		this.radius = radius;
	}

	//Method to Calculate and dispaly output

	public void CalculateArea()
	{
		double result = Math.PI * Math.Pow(radius, 2);
		Console.WriteLine("The radius  is : " + radius);

		Console.WriteLine("The Area of Circle is : " + result);
	}


}
