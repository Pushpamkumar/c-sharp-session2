using System;
using System.Collections.Generic;

#region BASE CLASS
// Base class representing common properties of all people
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}
#endregion

#region STUDENT CLASS (INHERITANCE)
// Student inherits Person
public class Student : Person
{
    public int Semester { get; set; }
}
#endregion

#region EXAMINER CLASS (INHERITANCE)
// Examiner inherits Person
public class Examiner : Person
{
    public string SubjectExpertise { get; set; }
}
#endregion

#region EXAM CLASS (ASSOCIATION)
// Exam is associated with Examiner
public class Exam
{
    public string ExamCode { get; set; }
    public string Subject { get; set; }
    public DateTime ExamDate { get; set; }
    public Examiner AssignedExaminer { get; set; }

    // Display exam details
    public void DisplayExam()
    {
        Console.WriteLine(
            $"Exam Code: {ExamCode} | Subject: {Subject} | Date: {ExamDate.ToShortDateString()} | Examiner: {AssignedExaminer.Name}"
        );
    }
}
#endregion

#region SCHEDULE CLASS (AGGREGATION)
// Schedule aggregates multiple exams
public class Schedule
{
    public List<Exam> Exams = new List<Exam>();

    // Add exam to schedule
    public void AddExam(Exam exam)
    {
        Exams.Add(exam);
    }

    // Display full schedule
    public void DisplaySchedule()
    {
        Console.WriteLine("\n----- SEMESTER EXAM SCHEDULE -----");
        foreach (Exam exam in Exams)
        {
            exam.DisplayExam();
        }
    }
}
#endregion

#region MAIN PROGRAM
class Program
{
    static void Main()
    {
        // ---------- USER INPUT ----------
        Console.Write("Enter number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        Console.Write("Enter semester (e.g. 2): ");
        int semester = int.Parse(Console.ReadLine());

        Console.Write("Enter number of subjects: ");
        int subjectCount = int.Parse(Console.ReadLine());

        Console.Write("Enter number of examiners: ");
        int examinerCount = int.Parse(Console.ReadLine());

        // ---------- CREATE STUDENTS ----------
        List<Student> students = new List<Student>();
        for (int i = 1; i <= studentCount; i++)
        {
            students.Add(new Student
            {
                Id = i,
                Name = "Student" + i,
                Semester = semester
            });
        }

        // ---------- CREATE EXAMINERS ----------
        List<Examiner> examiners = new List<Examiner>();
        for (int i = 1; i <= examinerCount; i++)
        {
            Console.Write($"Enter subject expertise of Examiner {i}: ");
            string expertise = Console.ReadLine();

            examiners.Add(new Examiner
            {
                Id = i,
                Name = "Examiner" + i,
                SubjectExpertise = expertise
            });
        }

        // ---------- CREATE SCHEDULE ----------
        Schedule schedule = new Schedule();

        // ---------- CREATE EXAMS ----------
        for (int i = 1; i <= subjectCount; i++)
        {
            Console.Write($"\nEnter subject name {i}: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter exam date (yyyy-mm-dd): ");
            DateTime examDate = DateTime.Parse(Console.ReadLine());

            // Examiner assigned in round-robin manner
            Examiner assignedExaminer = examiners[(i - 1) % examinerCount];

            Exam exam = new Exam
            {
                ExamCode = "SEM" + semester + "_SUB" + i,
                Subject = subjectName,
                ExamDate = examDate,
                AssignedExaminer = assignedExaminer
            };

            schedule.AddExam(exam);
        }

        // ---------- DISPLAY FINAL OUTPUT ----------
        Console.WriteLine($"\nSemester {semester} Exam Schedule for {studentCount} Students:");
        schedule.DisplaySchedule();
    }
}
#endregion
