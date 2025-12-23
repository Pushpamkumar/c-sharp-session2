using System;

class Program
{
    static void Main()
    {
        int choice;

        // do-while loop ensures menu runs at least once
        do
        {
            Console.Clear(); // Clears console for better readability

            // Display menu
            Console.WriteLine("===== C# Conditional Programs =====");
            Console.WriteLine("1. Height Category");
            Console.WriteLine("2. Largest of Three");
            Console.WriteLine("3. Leap Year Checker");
            Console.WriteLine("4. Quadratic Equation");
            Console.WriteLine("5. Admission Eligibility");
            Console.WriteLine("6. Electricity Bill");
            Console.WriteLine("7. Vowel or Consonant");
            Console.WriteLine("8. Triangle Type");
            Console.WriteLine("9. Quadrant Finder");
            Console.WriteLine("10. Grade Description");
            Console.WriteLine("11. Valid Date Check");
            Console.WriteLine("12. ATM Withdrawal");
            Console.WriteLine("13. Profit / Loss");
            Console.WriteLine("14. Rock Paper Scissors");
            Console.WriteLine("15. Simple Calculator");
            Console.WriteLine("0. Exit");

            // Read user choice
            Console.Write("\nEnter your choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine(); // Blank line for spacing

            // Execute based on choice
            switch (choice)
            {
                case 1: HeightCategory(); break;
                case 2: LargestOfThree(); break;
                case 3: LeapYear(); break;
                case 4: Quadratic(); break;
                case 5: Admission(); break;
                case 6: ElectricityBill(); break;
                case 7: VowelConsonant(); break;
                case 8: TriangleType(); break;
                case 9: Quadrant(); break;
                case 10: Grade(); break;
                case 11: ValidDate(); break;
                case 12: ATM(); break;
                case 13: ProfitLoss(); break;
                case 14: RockPaperScissors(); break;
                case 15: Calculator(); break;
                case 0:
                    Console.WriteLine("Exiting program... Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

            // Pause before showing menu again (except on exit)
            if (choice != 0)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

        } while (choice != 0); // Loop until user chooses Exit
    }

    // ------------------ METHODS ------------------

    static void HeightCategory()
    {
        Console.Write("Enter height in cm: ");
        int h = int.Parse(Console.ReadLine());

        if (h < 150) Console.WriteLine("Dwarf");
        else if (h <= 165) Console.WriteLine("Average");
        else if (h <= 190) Console.WriteLine("Tall");
        else Console.WriteLine("Abnormal");
    }

    static void LargestOfThree()
    {
        Console.Write("Enter three numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c) Console.WriteLine("Largest: " + a);
            else Console.WriteLine("Largest: " + c);
        }
        else
        {
            if (b > c) Console.WriteLine("Largest: " + b);
            else Console.WriteLine("Largest: " + c);
        }
    }

    static void LeapYear()
    {
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());

        if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }

    static void Quadratic()
    {
        Console.Write("Enter a, b, c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0) Console.WriteLine("Roots are real and distinct");
        else if (d == 0) Console.WriteLine("Roots are real and equal");
        else Console.WriteLine("Roots are imaginary");
    }

    static void Admission()
    {
        Console.Write("Enter Math, Physics, Chemistry marks: ");
        int m = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int total = m + p + c;

        if (m >= 65 && p >= 55 && c >= 50 &&
            (total >= 180 || (m + p) >= 140))
            Console.WriteLine("Eligible");
        else
            Console.WriteLine("Not Eligible");
    }

    static void ElectricityBill()
    {
        Console.Write("Enter units consumed: ");
        double u = double.Parse(Console.ReadLine());
        double bill;

        if (u <= 199) bill = u * 1.20;
        else if (u <= 400) bill = u * 1.50;
        else if (u <= 600) bill = u * 1.80;
        else bill = u * 2.00;

        if (bill > 400)
            bill += bill * 0.15;

        Console.WriteLine("Total Bill = " + bill);
    }

    static void VowelConsonant()
    {
        Console.Write("Enter character: ");
        char ch = char.ToLower(Console.ReadLine()[0]);

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }

    static void TriangleType()
    {
        Console.Write("Enter three sides: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Equilateral Triangle");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles Triangle");
        else
            Console.WriteLine("Scalene Triangle");
    }

    static void Quadrant()
    {
        Console.Write("Enter x and y: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0) Console.WriteLine("1st Quadrant");
        else if (x < 0 && y > 0) Console.WriteLine("2nd Quadrant");
        else if (x < 0 && y < 0) Console.WriteLine("3rd Quadrant");
        else if (x > 0 && y < 0) Console.WriteLine("4th Quadrant");
        else Console.WriteLine("On Axis");
    }

    static void Grade()
    {
        Console.Write("Enter grade: ");
        char g = char.ToUpper(Console.ReadLine()[0]);

        switch (g)
        {
            case 'E': Console.WriteLine("Excellent"); break;
            case 'V': Console.WriteLine("Very Good"); break;
            case 'G': Console.WriteLine("Good"); break;
            case 'A': Console.WriteLine("Average"); break;
            case 'F': Console.WriteLine("Fail"); break;
            default: Console.WriteLine("Invalid Grade"); break;
        }
    }

    static void ValidDate()
    {
        Console.Write("Enter day, month, year: ");
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool leap = (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0));
        int[] days = { 31, leap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (m >= 1 && m <= 12 && d >= 1 && d <= days[m - 1])
            Console.WriteLine("Valid Date");
        else
            Console.WriteLine("Invalid Date");
    }

    static void ATM()
    {
        Console.Write("Card inserted? (yes/no): ");
        if (Console.ReadLine() == "yes")
        {
            Console.Write("Pin valid? (yes/no): ");
            if (Console.ReadLine() == "yes")
            {
                Console.Write("Balance sufficient? (yes/no): ");
                if (Console.ReadLine() == "yes")
                    Console.WriteLine("Withdrawal Successful");
                else
                    Console.WriteLine("Insufficient Balance");
            }
            else Console.WriteLine("Invalid PIN");
        }
        else Console.WriteLine("Insert Card First");
    }

    static void ProfitLoss()
    {
        Console.Write("Enter Cost Price and Selling Price: ");
        double cp = double.Parse(Console.ReadLine());
        double sp = double.Parse(Console.ReadLine());

        if (sp > cp)
            Console.WriteLine("Profit % = " + ((sp - cp) / cp * 100));
        else if (cp > sp)
            Console.WriteLine("Loss % = " + ((cp - sp) / cp * 100));
        else
            Console.WriteLine("No Profit No Loss");
    }

    static void RockPaperScissors()
    {
        Console.Write("Player 1: ");
        string p1 = Console.ReadLine();
        Console.Write("Player 2: ");
        string p2 = Console.ReadLine();

        if (p1 == p2) Console.WriteLine("Draw");
        else if ((p1 == "rock" && p2 == "scissors") ||
                 (p1 == "paper" && p2 == "rock") ||
                 (p1 == "scissors" && p2 == "paper"))
            Console.WriteLine("Player 1 Wins");
        else
            Console.WriteLine("Player 2 Wins");
    }

    static void Calculator()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+ - * /): ");
        char op = Console.ReadLine()[0];

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine("Result = " + (a + b)); break;
            case '-': Console.WriteLine("Result = " + (a - b)); break;
            case '*': Console.WriteLine("Result = " + (a * b)); break;
            case '/':
                Console.WriteLine(b != 0 ? "Result = " + (a / b) : "Cannot divide by zero");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
