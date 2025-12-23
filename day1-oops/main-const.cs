using OopsSessions.ConstructorEX;
using System;

namespace OopsSessions
{
    // This class is used to test and execute
    // the Visitor class constructors
    public class MainConstuctor
    {
        // Main method: Entry point of the application
        public static void Main(string[] args)
        {
            // Creating Visitor object using default constructor
            // This will initialize LogHistory with object creation time
            Visitor dd = new Visitor();

            try
            {
                // Creating Visitor object using parameterized constructor
                // Constructor chaining will be executed in the following order:
                // Visitor() → Visitor(int) → Visitor(int, string) → Visitor(int, string, string)
                Visitor visitor = new Visitor(
                    10,
                    "Arunamukari",
                    "Please change my name"
                );
            }
            catch (Exception ex)
            {
                // Catching any exception thrown from constructor
                // Example: validation failure in name
                Console.WriteLine(ex.Message);
            }
        }
    }
}
