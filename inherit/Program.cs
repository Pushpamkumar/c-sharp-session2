using System;
class Employee{
    public virtual double CalculateSalary(){
        return 40000;
}
}
class Manager : Employee {
    public override double CalculateSalary(){
        return base.CalculateSalary()+10000;
    }
}
class Program{
    public static void Main(){
        Employee m = new Manager();
        Console.WriteLine(m.CalculateSalary());


    }
}