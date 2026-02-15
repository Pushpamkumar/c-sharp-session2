using System;

public class InvalidCreditDataException : Exception
{
    public InvalidCreditDataException(string message) : base(message)
    {
    }
}

public class Customer
{
    public string CustomerName { get; set; }
    public int Age { get; set; }
    public string EmploymentType { get; set; }
    public double MonthlyIncome { get; set; }
    public double ExistingCreditDues { get; set; }
    public int CreditScore { get; set; }
    public int NumberOfDefaults { get; set; }
}

public class CreditRiskProcessor
{
    public static void ValidateCustomer(Customer c)
    {
        if (c.Age < 21 || c.Age > 65)
            throw new InvalidCreditDataException("Invalid age");

        if (c.EmploymentType != "Salaried" &&
            c.EmploymentType != "Self-Employed")
            throw new InvalidCreditDataException("Invalid employment type");

        if (c.MonthlyIncome < 20000)
            throw new InvalidCreditDataException("Invalid monthly income");

        if (c.ExistingCreditDues < 0)
            throw new InvalidCreditDataException("Invalid credit dues");

        if (c.CreditScore < 300 || c.CreditScore > 900)
            throw new InvalidCreditDataException("Invalid credit score");

        if (c.NumberOfDefaults < 0)
            throw new InvalidCreditDataException("Invalid default count");
    }

    public static double CalculateCreditLimit(Customer c)
    {
        double debtRatio =
            c.ExistingCreditDues / (c.MonthlyIncome * 12);

        if (c.CreditScore < 600 ||
            c.NumberOfDefaults >= 3 ||
            debtRatio > 0.4)
        {
            return 50000;
        }

        if (c.CreditScore >= 750 &&
            c.NumberOfDefaults == 0 &&
            debtRatio < 0.25)
        {
            return 300000;
        }

        return 150000;
    }
}

class UserInterface
{
    static void Main()
    {
        try
        {
            Customer c = new Customer();

            Console.Write("Enter customer name: ");
            c.CustomerName = Console.ReadLine();

            Console.Write("Enter age: ");
            c.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter employment type: ");
            c.EmploymentType = Console.ReadLine();

            Console.Write("Enter monthly income: ");
            c.MonthlyIncome = double.Parse(Console.ReadLine());

            Console.Write("Enter existing credit dues: ");
            c.ExistingCreditDues = double.Parse(Console.ReadLine());

            Console.Write("Enter credit score: ");
            c.CreditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter number of loan defaults: ");
            c.NumberOfDefaults = int.Parse(Console.ReadLine());

            CreditRiskProcessor.ValidateCustomer(c);

            double limit =
                CreditRiskProcessor.CalculateCreditLimit(c);

            Console.WriteLine("Customer Name: " + c.CustomerName);
            Console.WriteLine("Approved Credit Limit: ₹" + limit);
        }
        catch (InvalidCreditDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
