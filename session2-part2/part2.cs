using System;
using System.Numerics; // For BigInteger (large factorials)

class Program
{
    static void Main()
    {
        int choice;

        // Menu runs continuously until user chooses Exit
        do
        {
            Console.Clear();
            Console.WriteLine("===== LOOP & LOGIC PROGRAMS =====");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Prime Number Check");
            Console.WriteLine("3. Armstrong Number");
            Console.WriteLine("4. Reverse & Palindrome");
            Console.WriteLine("5. GCD and LCM");
            Console.WriteLine("6. Pascal's Triangle");
            Console.WriteLine("7. Binary to Decimal");
            Console.WriteLine("8. Diamond Pattern");
            Console.WriteLine("9. Factorial (Large Numbers)");
            Console.WriteLine("10. Guessing Game");
            Console.WriteLine("11. Digital Root");
            Console.WriteLine("12. Continue Usage");
            Console.WriteLine("13. Strong Number");
            Console.WriteLine("14. Search using Goto");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1: Fibonacci(); break;
                case 2: Prime(); break;
                case 3: Armstrong(); break;
                case 4: ReversePalindrome(); break;
                case 5: GcdLcm(); break;
                case 6: Pascal(); break;
                case 7: BinaryToDecimal(); break;
                case 8: Diamond(); break;
                case 9: LargeFactorial(); break;
                case 10: GuessingGame(); break;
                case 11: DigitalRoot(); break;
                case 12: ContinueDemo(); break;
                case 13: StrongNumber(); break;
                case 14: GotoSearch(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }

            if (choice != 0)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

        } while (choice != 0);
    }

    // 1. Fibonacci Series
    static void Fibonacci()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1;
        Console.Write("Fibonacci: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }

    // 2. Prime Number using for + break
    static void Prime()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        bool prime = true;

        if (n <= 1) prime = false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break; // exit loop immediately
            }
        }

        Console.WriteLine(prime ? "Prime Number" : "Not Prime");
    }

    // 3. Armstrong Number
    static void Armstrong()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        int temp = num, digits = 0;
        double sum = 0;

        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }

        temp = num;
        while (temp > 0)
        {
            int d = temp % 10;
            sum += Math.Pow(d, digits);
            temp /= 10;
        }

        Console.WriteLine(sum == num ? "Armstrong Number" : "Not Armstrong");
    }

    // 4. Reverse & Palindrome
    static void ReversePalindrome()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int rev = 0, temp = n;

        while (temp > 0)
        {
            rev = rev * 10 + temp % 10;
            temp /= 10;
        }

        Console.WriteLine("Reverse: " + rev);
        Console.WriteLine(n == rev ? "Palindrome" : "Not Palindrome");
    }

    // 5. GCD and LCM
    static void GcdLcm()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int x = a, y = b;

        while (y != 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }

        int gcd = x;
        int lcm = (a * b) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }

    // 6. Pascal's Triangle
    static void Pascal()
    {
        Console.Write("Enter rows: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(num + " ");
                num = num * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }

    // 7. Binary to Decimal (no built-in)
    static void BinaryToDecimal()
    {
        Console.Write("Enter binary number: ");
        string bin = Console.ReadLine();

        int dec = 0, power = 1;

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            if (bin[i] == '1')
                dec += power;
            power *= 2;
        }

        Console.WriteLine("Decimal = " + dec);
    }

    // 8. Diamond Pattern
    static void Diamond()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }

        for (int i = n - 1; i >= 1; i--)
        {
            Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }
    }

    // 9. Factorial using BigInteger
    static void LargeFactorial()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;

        Console.WriteLine("Factorial = " + fact);
    }

    // 10. Guessing Game (do-while)
    static void GuessingGame()
    {
        int secret = 7, guess;

        do
        {
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

        } while (guess != secret);

        Console.WriteLine("Correct Guess!");
    }

    // 11. Digital Root
    static void DigitalRoot()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        while (n > 9)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }

        Console.WriteLine("Digital Root = " + n);
    }

    // 12. Continue Usage
    static void ContinueDemo()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
                continue;

            Console.Write(i + " ");
        }
    }

    // 13. Strong Number
    static void StrongNumber()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int temp = n, sum = 0;

        while (temp > 0)
        {
            int d = temp % 10;
            sum += Factorial(d);
            temp /= 10;
        }

        Console.WriteLine(sum == n ? "Strong Number" : "Not Strong");
    }

    static int Factorial(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }

    // 14. Search using goto
    static void GotoSearch()
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
        int target = 5;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (arr[i, j] == target)
                {
                    Console.WriteLine("Found at position [" + i + "," + j + "]");
                    goto Found; // exit all loops instantly
                }
            }
        }

        Console.WriteLine("Not Found");

    Found:
        Console.WriteLine("Search Completed");
    }
}
