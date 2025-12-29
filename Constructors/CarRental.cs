/*Car Rental System
o Create a CarRental class with attributes customerName, carModel, and
rentalDays.
o Add constructors to initialize the rental details and calculate total cost.*/


using System;

public class CarRental
{
	string customerName;
	string carModel;
	int rentalDays;


	public CarRental(string customerName, string carModel, int rentalDays)
	{
		this.customerName = customerName;
		this.carModel = carModel;
		this.rentalDays = rentalDays;
	}


	public void RentalDetails()
	{
		Console.WriteLine($"Customer Name  : {customerName}");
			Console.WriteLine($"Car Model  : {carModel}");
		Console.WriteLine($"Rental Days  : {rentalDays}");
		Console.WriteLine($"Total Cost  : {1500 * rentalDays} ");
	}
}
