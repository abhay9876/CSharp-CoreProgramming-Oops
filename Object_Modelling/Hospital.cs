/*Hospital, Doctors, and Patients (Association and Communication)
Description: Model a Hospital where Doctor and Patient objects interact through
consultations. A doctor can see multiple patients, and each patient can consult multiple
doctors.
Tasks:
● Define a Hospital class containing Doctor and Patient classes.
● Create a method Consult() in the Doctor class to show communication, which would
display the consultation between a doctor and a patient.
● Model an association between doctors and patients to show that doctors and
patients can have multiple relationships.
Goal: Practice creating an association with communication between objects by modeling
doctor-patient consultations.*/


using System;
// Hospital class
class Hospital
{
    public string HospitalName { get; }

    private List<Doctor> doctors = new();
    private List<Patient> patients = new();

    public Hospital(string hospitalName)
    {
        HospitalName = hospitalName;
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }
}

// Doctor Class
public class Doctor
{
	public string name;
	public Doctor(string name)
	{
		this.name = name;
	}
    // Communication Method
	public void Consult(Patient patient)
    {
        Console.WriteLine($"Doctor {name} is consulting patient {patient.name}");
    } 
}

//Patient class
public class Patient
{
	public string name;
	public Patient(string name)
	{
		this.name = name;
	}
}
