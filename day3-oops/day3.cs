using System;

namespace OopsSessions
{
    // Base class representing a generic Account
    // This class will be inherited by other account types
    public class Account
    {
        // Property to store the account holder's name
        public string Name { get; set; }

        // Property to store unique account ID
        public int AccountId { get; set; }

        // Method to return basic account details
        // This method can be reused by derived classes using 'base' keyword
        public string GetAccountDetails()
        {
            return $"I am Base account. My Id is {AccountId}";
        }
    }

    // Derived class inheriting from Account
    // Represents a Sales Account
    public class SalesAccount : Account
    {
        // Property specific to SalesAccount
        public string SalesInfo { get; set; }

        // Method to return sales account details
        // Uses base class method to reuse common account information
        public string GetSalesAccountDetails()
        {
            string info = string.Empty;

            // Calling base class method
            info += base.GetAccountDetails();

            // Adding derived class specific information
            info += " | I am from Sales derived class";

            return info;
        }
    }

    // Derived class inheriting from Account
    // Represents a Purchase Account
    public class PurchaseAccount : Account
    {
        // Property specific to PurchaseAccount
        public string PurchaseInfo { get; set; }
    }
}
