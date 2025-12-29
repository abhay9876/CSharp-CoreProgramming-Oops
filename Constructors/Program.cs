using System;
namespace Constructors
{
    class Program
    {
        public static void Main(string[] args)
        {
            BookClass b1 = new BookClass();
            b1.Display();
            BookClass b2 = new BookClass("World war 3", "Tony", 20);
            b2.Display();

            CircleClass c1 = new CircleClass();
            c1.Display();
            CircleClass c2 = new CircleClass(6.0);
            c2.Display();


            Person p1 = new Person("Zeno", 22);
            p1.Display();
            Person p2 = new Person(p1);
            p2.Display();

            HotelBooking h1 = new HotelBooking();
            h1.Display();
            HotelBooking h2 = new HotelBooking("Vegeta", "AC", 2);
            h2.Display();
            HotelBooking h3 = new HotelBooking(h2);
            h3.Display();

            Book b1 = new Book("Harry Potter", "Zeno", 2000);
            b1.BorrowBook();

            CarRental car1 = new CarRental("Zeno", "BMW M4", 5);
            car1.RentalDetails();

        }
    }
}