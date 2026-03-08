using System;
using System.Collections.Generic;
using System.Linq;
class InvalidSalaryException :Exception {
    public InvalidSalaryException (string message) : base (message) {

    }
}
class InvalidEmployeeName :Exception {
    public InvalidEmployeeName (string message) : base (message) {

    }
}
class InvalidEmployeeId :Exception {
    public InvalidEmployeeId (string message) : base (message) {

    }
}
class InvalidEmployeeDepart :Exception {
    public InvalidEmployeeDepart (string message) : base (message) {

    }
}
class DuplicateEmployeeException:Exception {
    public DuplicateEmployeeException (string message) : base (message) {

    }
}



class Employee{
    public string Id{set; get;}
    public string Name{set; get;}
    public string Depart{set; get;}
    public Double Salary{set; get;}
}

class EmployeeUtility{

    SortedDictionary<double, List<Employee>> emp1= new SortedDictionary<double, List<Employee>>(Comparer<Double>.Create((a,b)=>b.CompareTo(a)));
    Dictionary<string, Employee> LookUp = new Dictionary<string, Employee>();

    public void AddEmployee(Employee emp){
            if(emp.Salary <=0 ){
                throw new InvalidSalaryException("Invalid Salary Add");
            }
            if(string.IsNullOrWhiteSpace(emp.Name)){
                throw new InvalidEmployeeName("Invalid Employee Name");
            }
            if(string.IsNullOrWhiteSpace(emp.Id)){
                throw new InvalidEmployeeId("Invalid ID of Employee");
            }
            if(string.IsNullOrWhiteSpace(emp.Depart)){
                throw new InvalidEmployeeDepart("Invalid Department Name");
            }
            if(LookUp.ContainsKey(emp.Id)){
               throw new DuplicateEmployeeException("Dupliacte");
            }
            if(!emp1.ContainsKey(emp.Salary)){
                emp1[emp.Salary]= new List<Employee>();
            }
            emp1[emp.Salary].Add(emp);
            LookUp[emp.Id]= emp;

    }
    public  void GetAllEmployee(){
        if(emp1.Count==0){
            Console.WriteLine("No employeee");
        }
        foreach( var x in emp1){
            foreach ( var y in x.Value){
                Console.WriteLine($"Details are: {y.Id} {y.Name} {y.Salary} {y.Depart}");
            }
        }


    }
    public void UpdateSalary(string id, double newSalary){
        if(newSalary<=0){
            Console.WriteLine("Invalid input of new Salary");
            return;
            }
            if(!LookUp.ContainsKey(id)){
                Console.WriteLine("User Not found");
                return;
            }
            LookUp[id].Salary= newSalary;

            Console.WriteLine($"Updated Salary is {LookUp[id].Salary}");

    }
}

class Program{
    public static void Main(){
        // Employee m = new Employee();
        EmployeeUtility m1= new EmployeeUtility();
    

        while(true){

            Console.WriteLine("Details Employeee:");
            Console.WriteLine("Press 1 Display Employee:");
            Console.WriteLine("Press 2 Update Salary:");
            Console.WriteLine("Press 3 Add Employee:");
            Console.WriteLine("Press 4 Exit:");
            Employee m = new Employee();
    

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

        try{
            switch(choice){
                case 1:
                    m1.GetAllEmployee();
                    break;
                case 2:
                    Console.WriteLine("Enter Id of employee whose you want to update salary");
                    string a= Console.ReadLine();
                    Console.WriteLine("Enter updated Salary");
                    double Sal= Convert.ToDouble(Console.ReadLine());
                    m1.UpdateSalary(a, Sal);
                    break;
                case 3:
                    Console.WriteLine("Enter Employee ID");
                    m.Id= Console.ReadLine();

                    Console.WriteLine("Enter Employee Name");
                    m.Name= Console.ReadLine();
                    
                    Console.WriteLine("Enter Employee Depart");
                    m.Depart=Console.ReadLine();

                    Console.WriteLine("Enter Employee Salary");
                    m.Salary= Convert.ToDouble(Console.ReadLine());
                    
                    m1.AddEmployee(m);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
        }
        catch ( Exception ex){
            Console.WriteLine($"Error is {ex.Message}");

        }


            }


        }
    }
