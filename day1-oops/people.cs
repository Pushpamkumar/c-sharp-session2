using System;

namespace OopsSessions
{
    // Base class: Person
    // Contains common properties shared by all derived classes
    public class Person
    {
        // Default constructor
        // Initializes properties with safe default values
        public Person()
        {
            Id = 0;
            Name = string.Empty;
            age = 0;
        }

        // Unique identifier for the person
        public int Id { get; set; }

        // Name of the person
        public string Name { get; set; }

        // Age of the person
        // NOTE: By convention, property names should be PascalCase (Age)
        public int age { get; set; }
    }

    // Derived class: Man
    // Inherits all properties from Person
    public class Man : Person
    {
        // Default constructor
        // Initializes base class members and its own property
        public Man()
        {
            // These assignments are optional because
            // the base class constructor already initializes them
            Id = 0;
            Name = string.Empty;
            age = 0;

            // Property specific to Man class
            Playing = string.Empty;
        }

        // Activity or hobby of a man
        public string Playing { get; set; }
    }

    // Derived class: Woman
    // Inherits all properties from Person
    public class Woman : Person
    {
        // Default constructor
        // Initializes base class members and its own property
        public Woman()
        {
            // Base class initialization (already handled by Person constructor)
            Id = 0;
            Name = string.Empty;
            age = 0;

            // Property specific to Woman class
            PlayMange = string.Empty;
        }

        // Activity or hobby of a woman
        public string PlayMange { get; set; }
    }

    // Derived class: Child
    // Inherits from Person
    public class Child : Person
    {
        // Field specific to Child class
        // Represents what the child is watching
        // NOTE: It is better to use a property instead of a public field
        public string WatchingCartoon;
    }
}
