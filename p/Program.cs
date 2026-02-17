using System;

#region Abstract Base Class

// Abstract class Employee
abstract class Employee
{
    // Common properties
    public string EmployeeId { get; set; }
    public double BasicSalary { get; set; }

    // Abstract method (must be implemented by child classes)
    public abstract double CalculateGrossSalary();

    // Virtual method (can be overridden if needed)
    public virtual double GetTaxRate(double grossSalary)
    {
        if (grossSalary <= 40000)
            return 0.08;   // 8%
        else
            return 0.18;   // 18%
    }

    // Method to calculate net salary
    public double CalculateNetSalary()
    {
        double gross = CalculateGrossSalary();
        double taxRate = GetTaxRate(gross);
        double taxAmount = gross * taxRate;
        return gross - taxAmount;
    }

    // Static method for Employee ID validation
    public static bool ValidateEmployeeId(string id)
    {
        // Length must be 7
        if (id.Length != 7)
            return false;

        // Must start with EMP
        if (!id.StartsWith("EMP"))
            return false;

        // Last 4 characters must be digits
        string lastPart = id.Substring(3);

        if (!int.TryParse(lastPart, out _))
            return false;

        return true;
    }
}

#endregion

#region Permanent Employee Class

// PermanentEmployee inherits Employee
class PermanentEmployee : Employee
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Bonus { get; set; }

    // Gross Salary Formula
    public override double CalculateGrossSalary()
    {
        return BasicSalary + HRA + DA + Bonus;
    }
}

#endregion

#region Contract Employee Class

// ContractEmployee inherits Employee
class ContractEmployee : Employee
{
    public int WorkingDays { get; set; }
    public double PayPerDay { get; set; }

    // Gross Salary Formula
    public override double CalculateGrossSalary()
    {
        return WorkingDays * PayPerDay;
    }

    // Override Tax Rule (Flat 12%)
    public override double GetTaxRate(double grossSalary)
    {
        return 0.12;
    }
}

#endregion

#region Main Program

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Employee Type (1-Permanent, 2-Contract): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee ID: ");
        string empId = Console.ReadLine();

        // Validate Employee ID
        if (!Employee.ValidateEmployeeId(empId))
        {
            Console.WriteLine("Invalid employee id");
            return;  // Terminate program
        }

        Employee emp = null;

        if (type == 1)
        {
            // Permanent Employee
            PermanentEmployee pe = new PermanentEmployee();
            pe.EmployeeId = empId;

            Console.WriteLine("Enter Basic Salary: ");
            pe.BasicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter HRA: ");
            pe.HRA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter DA: ");
            pe.DA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bonus: ");
            pe.Bonus = Convert.ToDouble(Console.ReadLine());

            emp = pe;
        }
        else if (type == 2)
        {
            // Contract Employee
            ContractEmployee ce = new ContractEmployee();
            ce.EmployeeId = empId;

            Console.WriteLine("Enter Working Days: ");
            ce.WorkingDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Pay Per Day: ");
            ce.PayPerDay = Convert.ToDouble(Console.ReadLine());

            emp = ce;
        }
        else
        {
            Console.WriteLine("Invalid employee type");
            return;
        }

        // Calculate Gross and Net Salary
        double gross = emp.CalculateGrossSalary();
        double taxRate = emp.GetTaxRate(gross);
        double net = emp.CalculateNetSalary();

        // Output Format
        Console.WriteLine(
            $"Gross Salary: {gross:F2} | Tax Applied: {taxRate * 100}% | Net Salary: {net:F2}"
        );
    }
}

#endregion
