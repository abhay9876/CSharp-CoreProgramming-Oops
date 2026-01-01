using System;

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Animal
            Animal a1 = new Dog("Tommy", 3);
            Animal a2 = new Cat("Billi", 2);
            Animal a3 = new Bird("Parrot", 1);

            a1.MakeSound();
            a2.MakeSound();
            a3.MakeSound();



            // Employee Management
            Employee e1 = new Manager("Abhay", 101, 90000, 8);
            Employee e2 = new Developer("Zeno", 102, 70000, "C#");
            Employee e3 = new Intern("Goku", 103, 15000, "6 Months");
            e1.DisplayDetails();
            Console.WriteLine();
            e2.DisplayDetails();
            Console.WriteLine();
            e3.DisplayDetails();



            //VEhicle and Transport
            Vehicle[] vehicles = new Vehicle[]
            {
                 new Car(180, "Petrol", 5),
                 new Truck(120, "Diesel", 10000),
                 new Motorcycle(160, "Petrol", false)
            };

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine("-----------------------");
            }




            // Library Management
            Author bookWithAuthor = new Author("C#", 2026, "Abhay Singh", "Software Engineer");
            bookWithAuthor.DisplayInfo();



            // Smart Home Devices
            Device d1 = new Device(101, "ON");
            d1.DisplayStatus();
            Device d2 = new Thermostat(202, "ON", 24.5);
            d2.DisplayStatus();


            //Order Retail
            Order o1 = new Order(101, DateTime.Now);

            Order o2 = new ShippedOrder(102, DateTime.Now.AddDays(-2), "TRK12345");

            Order o3 = new DeliveredOrder(103, DateTime.Now.AddDays(-5), "TRK67890", DateTime.Now);

            Console.WriteLine(o1.GetOrderStatus());
            Console.WriteLine(o2.GetOrderStatus());
            Console.WriteLine(o3.GetOrderStatus());




            // Education
            Course c1 = new Course("Programming Basics", 10);
            Course c2 = new OnlineCourse("C# Online Course", 20, "Coursera", true);
            Course c3 = new PaidOnlineCourse("Advanced OOP in C#", 30, "Udemy", true, 1999, 20);
            c1.DisplayDetails();
            Console.WriteLine("-------------------");
            c2.DisplayDetails();
            Console.WriteLine("-------------------");
            c3.DisplayDetails();




            // Bank Account Type
            BankAccount[] accounts =
            {
                new SavingsAccount("SA100", 50000, 4.5),
                new CheckingAccount("CA200", 30000, 10000),
                new FixedDepositAccount("AD544", 100000, 24)
             };

            foreach (BankAccount account in accounts)
            {
                account.DisplayAccountType();
                Console.WriteLine($"Account No : {account.AccountNumber}");
                Console.WriteLine($"Balance : {account.Balance}");
                Console.WriteLine("------------------------");
            }


            // School System
            Person[] people =
            {
                new Teacher("Zeno", 40, "Mathematics"),
                new Student("Goku", 20, "B.Tech"),
                new Staff("Frezza", 35, "Administration")
            };

            foreach (Person p in people)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
                p.DisplayRole();
                Console.WriteLine("-----------------------");
            }



            //Restaurant (Hybrid inheritance via interfaces)
            Worker w1 = new Chef(1, "Ramesh");
            Worker w2 = new Waiter(2, "Suresh");

            w1.PerformDuties();
            w2.PerformDuties();



            // Vehicle
            ElectricVehicle ev = new ElectricVehicle("Tesla Model 3", 225);
            PetrolVehicle pv = new PetrolVehicle("Honda City", 190);

            ev.DisplayInfo();
            ev.Charge();

            Console.WriteLine("---------------------");

            pv.DisplayInfo();
            pv.Refuel();

        }
    }
}