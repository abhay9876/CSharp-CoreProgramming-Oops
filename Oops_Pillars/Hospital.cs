/*Hospital Patient Management
Description: Design a system to manage patients in a hospital.
● Abstract Class:
o Create an abstract class Patient with fields: patientId, name, and age.
o Add an abstract method CalculateBill().
o Implement a concrete method GetPatientDetails().
● Subclasses:
o Extend Patient into InPatient and OutPatient.
o Implement CalculateBill() differently for each subclass.
● Interface:
o Implement an interface IMedicalRecord.
o Define methods AddRecord() and ViewRecords().
● Encapsulation:
o Protect sensitive patient data like diagnosis and medical history.
● Polymorphism:
o Use a Patient reference to handle different patient types dynamically.
o Display billing details based on polymorphic behavior.*/


using System;

// Abstract class
public abstract class Patient
{
    // Encapsulation
    private int patientId;
    private string name;
    private int age;

    // Constructor
    public Patient(int id, string name, int age)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
    }

    public int PatientId
    {
        get { return patientId; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    // Abstract method
    public abstract double CalculateBill();

    // non-abstract method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

// Interface 
public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}


// InPatient class
public class InPatient : Patient, IMedicalRecord
{
    private List<string> medicalHistory = new List<string>();

    public InPatient(int id, string name, int age)
        : base(id, name, age)
    {
    }

    // Bill calculation 
    public override double CalculateBill()
    {
        return 1000; 
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History Records:");
        foreach (string record in medicalHistory)
        {
            Console.WriteLine(record);
        }
    }
}

// OutPatient class
public class OutPatient : Patient, IMedicalRecord
{
    private List<string> diagnosis = new List<string>();

    public OutPatient(int id, string name, int age)
        : base(id, name, age)
    {
    }

    // Bill calculation for OPD patient
    public override double CalculateBill()
    {
        return 500; 
    }

    public void AddRecord(string record)
    {
        diagnosis.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis Record:");
        foreach (string record in diagnosis)
        {
            Console.WriteLine(record);
        }
    }
}



