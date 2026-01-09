using System;

namespace DelegatePrintingExample
{
    //  Delegate that returns string
    public delegate string MessageDelegate(string message);

    class MessagePrinter
    {
        // PRIVATE method that actually prints
        private void PrintMessage(string message, MessageDelegate formatter)
        {
            string result = formatter(message);
            Console.WriteLine(result);
        }

        // PUBLIC method where customer chooses printing method
        public void Print(string message, int choice)
        {
            MessageDelegate formatter;

            switch (choice)
            {
                case 1:
                    formatter = NormalPrint;
                    break;

                case 2:
                    formatter = UpperCasePrint;
                    break;

                case 3:
                    formatter = LowerCasePrint;
                    break;

                case 4:
                    formatter = FancyPrint;
                    break;

                default:
                    formatter = NormalPrint;
                    break;
            }

            // Call private method
            PrintMessage(message, formatter);
        }

        // Formatting methods
        private string NormalPrint(string msg)
        {
            return msg;
        }

        private string UpperCasePrint(string msg)
        {
            return msg.ToUpper();
        }

        private string LowerCasePrint(string msg)
        {
            return msg.ToLower();
        }

        private string FancyPrint(string msg)
        {
            return $"*** {msg} ***";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MessagePrinter printer = new MessagePrinter();

            Console.WriteLine("Choose printing method:");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Uppercase");
            Console.WriteLine("3. Lowercase");
            Console.WriteLine("4. Fancy");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter message: ");
            string message = Console.ReadLine();

            printer.Print(message, choice);
        }
    }
}
