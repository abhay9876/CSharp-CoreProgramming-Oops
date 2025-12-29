using System;
using System.Net.NetworkInformation;
namespace Access_Modifier
{
    class Program
    {
        public static void Main(string[] args)
        {

            University Management System
           PostgraduateStudent ps = new PostgraduateStudent(01, "Zeno", 9, "B.Tech");
            ps.DisplayDetails();

            ps.SetCGPA(10);
            Console.WriteLine($"Updated CGPA : {ps.GetCGPA()}");


            Book Library System
            Ebook e = new Ebook(12345, "Gla", "Zeno", "Online");
            e.DisplayDetails();

            e.SetAuthor("Abhay");
            Console.WriteLine($"Updated Author : {e.GetAuthor()}");



            SavingsAccount sa = new SavingsAccount(2356, "Zeno", 20000000000, "Saving");
            sa.DisplayDetails();
            sa.SetBalance(5000000000000000);
            Console.WriteLine($"Updated balance : {sa.GetBalance()}");


            Manager man = new Manager(123, "IT", 100000);
            man.DisplayDetails();

            man.SetSalary(200000);
            Console.WriteLine($"Updated Salary : {man.GetSalary()}");
        }
    }
}