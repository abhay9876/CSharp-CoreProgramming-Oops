using System;
namespace Instances
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Product Inventory
            Product p1 = new Product("Laptop", 75000);
            Product p2 = new Product("Mouse", 1200);
            Product p3 = new Product("Keyboard", 2500);

            p1.DisplayProductDetails();
            p2.DisplayProductDetails();

            Product.DisplayTotalProducts();


            // Courses
            Course c1 = new Course("Full Stack Development", 24, 60000);
            Course c2 = new Course("Data Structures & Algorithms", 16, 40000);

            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();

            Course.UpdateInstituteName(".NET Learning");

            c1.DisplayCourseDetails();
            c2.DisplayCourseDetails();


            // Vehicle Rental System
            Vehicle v1 = new Vehicle("Abhay", "Car");
            Vehicle v2 = new Vehicle("Zeno", "Bike");

            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();

            Vehicle.UpdateRegistrationFee(6500);

            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();

        }
    }
}