/*Hotel Booking System
o Create a HotelBooking class with attributes guestName, roomType, and
nights.
o Use default, parameterized, and copy constructors to initialize bookings.*/


using System;

public class HotelBooking
{
	string guestName;
	string roomType;
	int nights;

	public HotelBooking()
	{
		guestName = "Goku";
		roomType = "AC";
		nights = 3;
	}

	public HotelBooking(string guestName , string roomType, int nights)
	{
		this.guestName = guestName;
		this.roomType = roomType;
		this.nights = nights;
	}


	public HotelBooking(HotelBooking booking)
	{
		this.guestName = booking.guestName;
		this.roomType = booking.roomType;
		this.nights = booking.nights;
	}


	public void Display()
	{
		Console.WriteLine($"Guest Name : {guestName}");
        Console.WriteLine($"Room Type : {roomType}");
        Console.WriteLine($"Nights : {nights}");
    }
}
