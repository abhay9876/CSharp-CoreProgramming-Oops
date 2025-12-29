/*Hospital Management System
Create a Patient class with the following features:
● static:
o A static variable HospitalName shared among all patients.
o A static method GetTotalPatients() to count the total patients admitted.
● this:
o Use this to initialize Name, Age, and Ailment in the constructor.
● readonly:
o Use a readonly variable PatientID to uniquely identify each patient.
● is operator:
o Check if an object is an instance of the Patient class before displaying its
details.*/



using System;

public class Patient
{
    //static variable
    public static string hospitalName = "City Hospital";
    public static int patientNumber = 0;

    // Instance Variable
    string name;
    readonly string id;
     int age;
    string ailment;

    // Constructor
    public Patient(string name, string id, int age, string ailment)
    {
        this.name = name;
        this.id = id;
        this.age = age;
        this.ailment = ailment;
        patientNumber++;
    }


    // static method to Display the number of patient
    public static int DisplayTotalPatient()
    {
        return patientNumber;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($" Patient Name : {name}");
        Console.WriteLine($" Id : {id}");
        Console.WriteLine($" Age  : {age}");
        Console.WriteLine($" Ailment  : {ailment}");
    }
}

public class Hospital
{
    public static void Run()
    {
        Console.WriteLine($"WelCome to {Patient.hospitalName}");
        Console.WriteLine("Patient Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Id  : ");
        string id = Console.ReadLine();
        Console.WriteLine("Age  : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Ailment : ");
        string ailment = Console.ReadLine();

        // object reference for is-operator check
        object obj = new Patient(name, id,age, ailment);

        // is operator validation
        if (obj is Patient patient)
        {
            patient.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Invalid Patient object.");
        }

        Console.WriteLine("Total Patient in Hospital : " + Patient.DisplayTotalPatient());
    }

}