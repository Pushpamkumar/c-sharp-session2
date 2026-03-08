using System;
using System.Linq;
using System.Collections.Generic;


public class Patient
{
    // TODO: Add properties with get/set accessors
    // TODO: Add constructor
    public int id{get; set;}
    public string Name {set; get;}
    public int Age{set; get;}
    public string Condition{ set; get;}

    public Patient(int id, string Name, int Age, string Condition){
        this.id=id;
        this.Name=Name;
        this.Age=Age;
        this.Condition=Condition;
    } 

}

// Task 2: Implement HospitalManager class
public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();
    
    // Add a new patient to the system
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        // TODO: Create patient and add to dictionary
        if(_patients.ContainsKey(id)){
            Console.WriteLine("Patient Already exits");
            return;
        }

        Patient pat= new Patient(id, name, age, condition);
        _patients.Add(id, pat);


    }
    
    // Add patient to appointment queue
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
        if(_patients.ContainsKey(patientId)){
            _appointmentQueue.Enqueue(_patients[patientId]);
        }
        else{
            Console.WriteLine("User Not found");
        }
    }
    
    // Process next appointment (remove from queue)
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
        if(_appointmentQueue.Count==0){
            return null;
        }
        return 
    }
    
    // Find patients with specific condition using LINQ
    public List<Patient> FindPatientsByCondition(string condition)
    {
        // TODO: Use LINQ to filter patients
    }
}
HospitalManager manager = new HospitalManager();
manager.RegisterPatient(1, "John Doe", 45, "Hypertension");
manager.RegisterPatient(2, "Jane Smith", 32, "Diabetes");
manager.ScheduleAppointment(1);
manager.ScheduleAppointment(2);

var nextPatient = manager.ProcessNextAppointment();
Console.WriteLine(nextPatient.Name); // Should output: John Doe

var diabeticPatients = manager.FindPatientsByCondition("Diabetes");
Console.WriteLine(diabeticPatients.Count); 
