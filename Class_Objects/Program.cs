using System;
namespace Class_Objects
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeDetails ed = new EmployeeDetails("Abhay", 22, 25000);
            Console.WriteLine($"Employee Detail :");
            ed.DisplayDetails();

            EmployeeDetails ed1 = new EmployeeDetails("Jayakant", 80, 25000);
            Console.WriteLine($"Employee Detail :");
            ed1.DisplayDetails();


            AreaOfCircle ac = new AreaOfCircle(12);
            ac.CalculateArea();
            AreaOfCircle ac1 = new AreaOfCircle(13);
            ac1.CalculateArea();


            HandleBookDetails hd = new HandleBookDetails("The IGL", "Zeno", 2000000);
            hd.BookDetails();
            HandleBookDetails hd1 = new HandleBookDetails("The Scout", "Monster", 200000);
            hd1.BookDetails();
        }
    }
}