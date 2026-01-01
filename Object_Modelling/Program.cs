using System;
using System.Runtime.InteropServices;
namespace Object_Modelling
{
    class Program
    {
        public static void Main(string[] args)
        {
            Library and Books
            Book bk1 = new Book("Earth", "Zeno");
            Book bk2 = new Book("Mars", "Goku");
            Library l1 = new Library("Central Library");
            Library l2 = new Library("Local Library");
            l1.AddBook(bk1);
            l1.AddBook(bk2);
            l1.BookDetails();
            l2.AddBook(bk1);
            l2.AddBook(bk2);
            l2.BookDetails();
            l1.RemoveBook(bk1);
            l1.BookDetails();




            Bank and Account Holders
            Bank b1 = new Bank("Global Bank");
            Customer c1 = new Customer("alien");
            b1.OpenAccount(c1, 50000);
            c1.ViewBalance(b1);
            Bank b2 = new Bank("Local Bank");
            b2.OpenAccount(c1, 2000);
            c1.ViewBalance(b2);


            School and Students
            School s = new School("DPS");
            Student st1 = new Student("Abhay");
            Student st2 = new Student("Sai");
            Course c1 = new Course("Frontend");
            Course c2 = new Course("Backend");
            s.AddStudents(st1);
            s.AddStudents(st2);
            c1.Enrolled(st1);
            c2.Enrolled(st1);
            c1.Enrolled(st2);
            c2.Enrolled(st2);
            c1.EnrolledStudents();


            Company and Deparments
           Company company = new Company("TechNova Pvt Ltd");
            company.AddDepartment("IT");
            company.AddDepartment("HR");
            company.GetDepartment("IT").AddEmployee("Abhay");
            company.GetDepartment("IT").AddEmployee("JayKant");
            company.GetDepartment("HR").AddEmployee("Zeno");
            company.ShowCompanyDetails();



            Hospital, Doctors , Patients
            Hospital hospital = new Hospital("City Hospital");
            Doctor d1 = new Doctor("Dr. Sharma");
            Doctor d2 = new Doctor("Dr. Verma");
            Patient pt1 = new Patient("Beerus");
            Patient pt2 = new Patient("Vegeta");
            hospital.AddDoctor(d1);
            hospital.AddDoctor(d2);
            hospital.AddPatient(pt1);
            hospital.AddPatient(pt2);
            // Communication
            d1.Consult(p1);
            d1.Consult(p2);
            d2.Consult(p1);


            University , Departments, Faculty
            University un = new University("GLA");
            un.AddDepartment("Training Department");
            un.AddDepartment("Computer Science");
            Faculty f1 = new Faculty("Robo1");
            Faculty f2 = new Faculty("Robo2");
            Department1 csDept = un.GetDepartment("Computer Science");
            csDept.AddFaculty(f1);
            csDept.AddFaculty(f2);



            Product p1 = new Product("Laptop", 65000);
            Product p2 = new Product("Mouse", 1200);
            Product p3 = new Product("Keyboard", 2500);
            Order order1 = new Order(101);
            order1.AddProduct(p1);
            order1.AddProduct(p2);
            order1.AddProduct(p3);
            Customer customer = new Customer("Abhay");
            customer.PlaceOrder(order1);


            Learner le1 = new Learner("Abhay");
            Learner le2 = new Learner("Sai");
            Instructor ins1 = new Instructor("Google");
            Subject sub1 = new Subject("OOPs");
            le1.EnrollSubject(sub1);
            le2.EnrollSubject(sub1);
            ins1.AssignToSubject(sub1);


        }
    }
}