using System;

class Manager{
    public int id;
    public string name;

    public void ShowMan(){
        Console.WriteLine($"Id is: {id}");
        Console.WriteLine($"Name is: {name}");
    }
}


class Employee : Manager{
    public int size;

    public void show(){
        Console.WriteLine($"Team size is: {size} ");
    }
}

class Program{
    public static void Main(){
        Employee m1= new Employee();
        m1.id=1;
        m1.name="Pushpam";
        m1.size=200;

        m1.ShowMan();
        // m1.ShowMan();

    }
}