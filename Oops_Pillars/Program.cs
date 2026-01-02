using System;
namespace Oops_Pillars
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// Employee
            //Employee emp1 = new FullTimeEmployee(1, "Abhay", 100000);
            //Employee emp2 = new PartTimeEmployee(2, "Zeno", 1000, 90);
            //emp1.DisplayDetails();
            //emp2.DisplayDetails();


            //// E-Commerce
            //List<Product> products = new List<Product>();
            //products.Add(new Electronics(1, "Laptop", 60000));
            //products.Add(new Clothing(2, "Jacket", 4000));
            //products.Add(new Groceries(3, "Rice Bag", 1200));            //foreach (Product product in products)
            //{
            //    double tax = 0;
            //    if (product is ITaxable taxableProduct)
            //    {
            //        tax = taxableProduct.CalculateTax();
            //        Console.WriteLine(taxableProduct.GetTaxDetails());
            //    }
            //    double discount = product.CalculateDiscount();
            //    double finalPrice = product.GetPrice + tax - discount;

            //    Console.WriteLine(
            //        $"Product: {product.GetName}      Final Price: {finalPrice}"
            //    );
            //    Console.WriteLine("---------------------");




            //// Vehicle
            //List<Vehicle> vehicles = new List<Vehicle>
            //{
            //    new Car("BMW111", 1500, "CAR-HAI"),
            //    new Bike("KAWASAKI000", 500, "BIKE-HAI"),
            //    new Truck("VOLVO222", 3000)
            // };
            //int days = 2;
            //foreach (Vehicle vehicle in vehicles)
            //{
            //    double rentalCost = vehicle.CalculateRentalCost(days);
            //    double insuranceCost = 0;
            //    if (vehicle is IInsurable insurable)
            //    {
            //        insuranceCost = insurable.CalculateInsurance(days);
            //        Console.WriteLine(insurable.GetInsuranceDetails());
            //    }
            //    Console.WriteLine("Vehicle Type: " + vehicle.Type);
            //    Console.WriteLine("Vehicle Number: " + vehicle.VehicleNumber);
            //    Console.WriteLine("Rental Cost: " + rentalCost);
            //    Console.WriteLine("Insurance Cost: " + insuranceCost);
            //    Console.WriteLine("Total Cost: " + (rentalCost + insuranceCost));
            //    Console.WriteLine("------------------------------------");
            //}




            ////Bank
            //List<BankAccount> accounts = new List<BankAccount>();
            //accounts.Add(new SavingsAccount(101, "Abhay", 100000));
            //accounts.Add(new CurrentAccount(102, "Ravi", 20000));
            //foreach (BankAccount account in accounts)
            //{
            //    double interest = account.CalculateInterest();

            //    Console.WriteLine("Account Holder: " + account.HolderName);
            //    Console.WriteLine("Account Number: " + account.AccountNumber);
            //    Console.WriteLine("Balance: " + account.Balance);
            //    Console.WriteLine("Interest: " + interest);
            //    Console.WriteLine("----------------------------");
            //}



            ////Library
            //List<LibraryItem> items = new List<LibraryItem>();
            //items.Add(new Book(1, "C#", "Microsoft"));
            //items.Add(new Magazine(2, "Harry Potter", "Harry"));
            //items.Add(new DVD(3, "Dhoom", "Akshay"));
            //foreach (LibraryItem item in items)
            //{
            //    item.GetItemDetails();
            //    Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            //    if (item is IReservable reservable)
            //    {
            //        reservable.ReserveItem();
            //        Console.WriteLine("Available: " + reservable.CheckAvailability());
            //    }

            //    Console.WriteLine("-----------------------------");
            //}






            //// History
            //List<Patient> patients = new List<Patient>();
            //patients.Add(new InPatient(1, "Abhay", 22));
            //patients.Add(new OutPatient(2, "Zeno", 6));
            //foreach (Patient patient in patients)
            //{
            //    patient.GetPatientDetails();
            //    double bill = patient.CalculateBill();
            //    Console.WriteLine("Bill Amount: " + bill);
            //    if (patient is IMedicalRecord record)
            //    {
            //        record.AddRecord("General Checkup");
            //        record.ViewRecords();
            //    }
            //    Console.WriteLine("-----------------------------");
            //}







            //// Ride-Hailing
            //double distance = 15;
            //List<Vehicle> vehicles = new List<Vehicle>();
            //vehicles.Add(new Car(1, "Zeno"));
            //vehicles.Add(new Bike(2, "Goku"));
            //vehicles.Add(new Auto(3, "Beerus"));

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.GetVehicleDetails();

            //    double fare = vehicle.CalculateFare(distance);
            //    Console.WriteLine("Fare: " + fare);
            //    if (vehicle is IGPS gps)
            //    {
            //        gps.UpdateLocation("City Center");
            //        Console.WriteLine("Current Location: " + gps.GetCurrentLocation());
            //    }

            //    Console.WriteLine("----------------------------");
            //}
        }

     }
}