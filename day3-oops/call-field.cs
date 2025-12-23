using System;

namespace OopsSessions
{
    // This class is used to call and test Employee class members
    public class CallField
    {
        // Main method: Entry point of the application
        public static void Main(string[] args)
        {
            // Creating an object of Employee class
            Employee employee = new Employee();

            // Assigning value to the public property 'Id'
            // Direct access to fields is avoided for encapsulation
            employee.Id = 100;

            // The below line is commented because 'id' might be a private field
            // and cannot be accessed directly from outside the class
            // Console.WriteLine(employee.id);

            // Calling method to get employee details
            string result = employee.DisplayEmpDetails();

            // Printing employee details on the console
            Console.WriteLine(result);
        }
    }
}
