using System;

// Delegate
public delegate int Calculate(int a, int b);

class Calculator
{
    public Calculate Operation;

    public int DoCalculation(int x, int y)
    {
        return Operation(x, y); 
    }
}

class MathOperations
{
    public static int Add(int a, int b)
    {
        
        int result = a + b;
        Console.WriteLine("Add Result: " + result);
        return result;
    }

    public static int Multiply(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Multiply Result: " + result);
        return result;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // attach both methods
        calc.Operation = MathOperations.Add;
        calc.Operation += MathOperations.Multiply;

        int finalResult = calc.DoCalculation(10, 5);

        Console.WriteLine("Final Returned Value: " + finalResult);
        Console.ReadLine();
    }
}
