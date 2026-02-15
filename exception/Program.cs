using System;
using System.Linq;
using System.Collections.Generic;


class Raj:Exception{
    public Raj(string message) : base(message)
    {

    }
}

class Program{
    public static void Main(){
        try{
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int c = a/b;
            Console.WriteLine($" Final result is {c}");
        }catch (Exception){
            throw new Raj("Invalid Denominator");
        }
        finally{
            Console.WriteLine("Baby");
        }
    }
}