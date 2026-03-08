using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeLINQAssignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee{ EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", DOB=new DateTime(1984,11,16), DOJ=new DateTime(2011,6,8), City="Mumbai"},
                new Employee{ EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", DOB=new DateTime(1984,8,20), DOJ=new DateTime(2012,7,7), City="Mumbai"},
                new Employee{ EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", DOB=new DateTime(1987,1,14), DOJ=new DateTime(2015,12,14), City="Pune"},
                new Employee{ EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", DOB=new DateTime(1990,6,3), DOJ=new DateTime(2016,2,2), City="Pune"},
                new Employee{ EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", DOB=new DateTime(1991,3,8), DOJ=new DateTime(2016,2,2), City="Mumbai"},
                new Employee{ EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", DOB=new DateTime(1989,11,7), DOJ=new DateTime(2014,8,8), City="Chennai"},
                new Employee{ EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", DOB=new DateTime(1989,12,2), DOJ=new DateTime(2015,6,1), City="Mumbai"},
                new Employee{ EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", DOB=new DateTime(1993,11,11), DOJ=new DateTime(2014,11,6), City="Chennai"},
                new Employee{ EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", DOB=new DateTime(1992,8,12), DOJ=new DateTime(2014,12,3), City="Chennai"},
                new Employee{ EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", DOB=new DateTime(1991,4,12), DOJ=new DateTime(2016,1,2), City="Pune"}
            };

            Console.WriteLine("f) Employees born after 1/1/1990:");
            var dobAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach (var emp in dobAfter1990)
                Console.WriteLine(emp.FirstName);

            Console.WriteLine("\ng) Consultant and Associate employees:");
            var consultantAssociate = empList
                .Where(e => e.Title == "Consultant" || e.Title == "Associate");
            foreach (var emp in consultantAssociate)
                Console.WriteLine(emp.FirstName);

            Console.WriteLine("\nh) Total number of employees:");
            Console.WriteLine(empList.Count());

            Console.WriteLine("\ni) Total employees in Chennai:");
            Console.WriteLine(empList.Count(e => e.City == "Chennai"));

            Console.WriteLine("\nj) Highest Employee ID:");
            Console.WriteLine(empList.Max(e => e.EmployeeID));

            Console.WriteLine("\nk) Employees joined after 1/1/2015:");
            Console.WriteLine(empList.Count(e => e.DOJ > new DateTime(2015, 1, 1)));

            Console.WriteLine("\nl) Total employees not Associate:");
            Console.WriteLine(empList.Count(e => e.Title != "Associate"));

            Console.WriteLine("\nm) Total employees based on City:");
            var cityGroup = empList
                .GroupBy(e => e.City)
                .Select(g => new { City = g.Key, Count = g.Count() });

            foreach (var item in cityGroup)
                Console.WriteLine($"{item.City} : {item.Count}");

            Console.WriteLine("\nn) Total employees based on City and Title:");
            var cityTitleGroup = empList
                .GroupBy(e => new { e.City, e.Title })
                .Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() });

            foreach (var item in cityTitleGroup)
                Console.WriteLine($"{item.City} - {item.Title} : {item.Count}");

            Console.WriteLine("\no) Youngest employee:");
            var youngest = empList
                .OrderByDescending(e => e.DOB)
                .First();

            Console.WriteLine(youngest.FirstName);

            Console.ReadLine();
        }
    }
}