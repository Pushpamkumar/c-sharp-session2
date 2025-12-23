using System;

namespace OopsSessionsEx
{
    // Base class: Student
    // Contains common properties shared by all students
    public class Student
    {
        // Unique identifier for the student
        public int Id { get; set; }

        // Name of the student
        public string Name { get; set; }

        // Age of the student
        public int Age { get; set; }

        // Section in which the student is enrolled
        public string Section { get; set; }
    }

    // Derived class: UGStudent
    // Inherits from Student class
    // Represents Undergraduate students
    public class UGStudent : Student
    {
        // Core subject studied by UG student
        public string CoreSubject { get; set; }
    }

    // Derived class: PGStudent
    // Inherits from UGStudent (Multilevel Inheritance)
    // Represents Postgraduate students
    public class PGStudent : UGStudent
    {
        // UG Degree completed by the PG student
        public string UGDegree { get; set; }
    }
}
