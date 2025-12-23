using System;

namespace OopsSessions
{
    // This class is responsible for executing the program
    // It contains the Main method (entry point of the application)
    public class CallAccount
    {
        // Main method: Program execution starts from here
        public static void Main(string[] args)
        {
            // Creating an object of the base Account class
            // Initializing properties using object initializer
            Account account = new Account()
            {
                AccountId = 1,
                Name = "Account1"
            };

            // Calling base class method to get account details
            string result = account.GetAccountDetails();

            // Creating an object of the derived SalesAccount class
            // SalesAccount inherits properties from Account
            SalesAccount salesAccount = new SalesAccount()
            {
                AccountId = 1,
                Name = "Balu",
                SalesInfo = "Sales Department"
            };

            // Calling derived class method which internally
            // calls the base class method using 'base' keyword
            string result1 = salesAccount.GetSalesAccountDetails();

            // Displaying results on the console
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
