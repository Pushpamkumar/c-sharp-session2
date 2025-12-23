using System;

namespace OopsSessions
{
    // Employee class demonstrates ENCAPSULATION
    // using private fields and public properties
    public class Employee
    {
        // Private field
        // Direct access from outside the class is not allowed
        private int id;

        // Public property to set the value of private field 'id'
        // This allows validation before assignment
        public int Id
        {
            set
            {
                // Validation: Id must be greater than zero
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    // Assigning default value when invalid input is provided
                    id = 0;

                    // Throwing exception to notify invalid operation
                    throw new InvalidOperationException(
                        "Employee Id cannot be less than or equal to zero");
                }
            }
        }

        // Public method to display employee details
        // Accesses private field internally
        public string DisplayEmpDetails()
        {
            return $"Employee Id is {id}";
        }
    }
}
