using System;

namespace OopsSessions
{
    /// <summary>
    /// Represents a Student entity.
    /// This class demonstrates fields, constructor, regions,
    /// and XML documentation comments.
    /// </summary>
    public class Student
    {
        #region Declaration

        // Public field to store Student Id
        // NOTE: In real projects, properties are preferred over public fields
        public int Id;

        // Public field to store Student Name
        public string Name;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// Initializes student fields with default values
        /// </summary>
        public Student()
        {
            Id = 0;
            Name = string.Empty;
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Returns formatted student details
        /// </summary>
        /// <returns>
        /// A string containing student Id and Name
        /// </returns>
        public string GetDetails()
        {
            return "Id " + Id + " Name " + Name;
        }

        #endregion
    }
}
