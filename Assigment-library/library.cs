using System;
using System.Collections.Generic;

/*
=====================================================
MAIN NAMESPACE
This namespace represents the complete library system
=====================================================
*/
namespace LibrarySystem
{
    /*
    --------------------------------------------
    TASK 7: ENUMERATIONS
    Enums restrict values to a fixed set
    --------------------------------------------
    */

    // Defines different types of users in the system
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    // Defines current status of a library item
    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }

    /*
    --------------------------------------------
    TASK 1: ABSTRACT CLASS
    Base class for all library items
    --------------------------------------------
    */
    public abstract class LibraryItem
    {
        // Common properties shared by all library items
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemID { get; set; }

        // Abstract method to display item details
        // Must be implemented by child classes
        public abstract void DisplayItemDetails();

        // Abstract method to calculate late fee
        // Logic differs based on item type
        public abstract double CalculateLateFee(int days);
    }

    /*
    --------------------------------------------
    TASK 2: INTERFACES
    Interfaces define optional behaviors
    --------------------------------------------
    */

    // Interface for reserving items
    public interface IReservable
    {
        void ReserveItem();
    }

    // Interface for sending notifications
    public interface INotifiable
    {
        void SendNotification(string message);
    }

    /*
    --------------------------------------------
    TASK 5: NESTED NAMESPACE (ITEMS)
    Contains all item-related classes
    --------------------------------------------
    */
    namespace Items
    {
        /*
        --------------------------------------------
        BOOK CLASS
        Inherits LibraryItem
        Implements two interfaces
        --------------------------------------------
        */
        public class Book : LibraryItem, IReservable, INotifiable
        {
            /*
            TASK 4: EXPLICIT INTERFACE IMPLEMENTATION
            These methods can only be accessed
            using interface references
            */

            void IReservable.ReserveItem()
            {
                Console.WriteLine("Book reserved successfully.");
            }

            void INotifiable.SendNotification(string message)
            {
                Console.WriteLine("Notification: " + message);
            }

            // Displays book-specific details
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Book");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Item ID: " + ItemID);
            }

            // Book late fee = 1 unit per day
            public override double CalculateLateFee(int days)
            {
                return days * 1.0;
            }
        }

        /*
        --------------------------------------------
        MAGAZINE CLASS
        Inherits LibraryItem
        --------------------------------------------
        */
        public class Magazine : LibraryItem
        {
            // Displays magazine details
            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: Magazine");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Item ID: " + ItemID);
            }

            // Magazine late fee = 0.5 units per day
            public override double CalculateLateFee(int days)
            {
                return days * 0.5;
            }
        }

        /*
        --------------------------------------------
        BONUS TASK: eBook CLASS
        Digital item with extra behavior
        --------------------------------------------
        */
        public class eBook : LibraryItem
        {
            // Digital-specific behavior
            public void Download()
            {
                Console.WriteLine("eBook downloaded successfully.");
            }

            public override void DisplayItemDetails()
            {
                Console.WriteLine("Item Type: eBook");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Item ID: " + ItemID);
            }

            // No late fee for eBooks
            public override double CalculateLateFee(int days)
            {
                return 0;
            }
        }
    }

    /*
    --------------------------------------------
    TASK 5: NESTED NAMESPACE (USERS)
    Contains user-related classes
    --------------------------------------------
    */
    namespace Users
    {
        public class Member
        {
            // Stores user name
            public string Name { get; set; }

            // Stores user role using enum
            public UserRole Role { get; set; }
        }
    }

    /*
    --------------------------------------------
    TASK 6: PARTIAL CLASS
    Part 1: Data storage
    --------------------------------------------
    */
    public partial class LibraryAnalytics
    {
        // Static property shared by entire system
        public static int TotalBorrowedItems { get; set; }
    }

    /*
    --------------------------------------------
    TASK 6: PARTIAL CLASS
    Part 2: Behavior
    --------------------------------------------
    */
    public partial class LibraryAnalytics
    {
        // Displays analytics data
        public static void DisplayAnalytics()
        {
            Console.WriteLine("Total Items Borrowed: " + TotalBorrowedItems);
        }
    }

    /*
    --------------------------------------------
    MAIN PROGRAM EXECUTION
    --------------------------------------------
    */
    class Program
    {
        static void Main()
        {
            // Namespace alias to reduce long names
            using ItemsAlias = LibrarySystem.Items;

            /*
            TASK 1: OBJECT CREATION
            */
            ItemsAlias.Book book = new ItemsAlias.Book
            {
                Title = "C# Fundamentals",
                Author = "John Doe",
                ItemID = 101
            };

            ItemsAlias.Magazine magazine = new ItemsAlias.Magazine
            {
                Title = "Tech Today",
                Author = "Jane Doe",
                ItemID = 201
            };

            // Display book details and late fee
            book.DisplayItemDetails();
            Console.WriteLine("Late Fee for 3 days: " + book.CalculateLateFee(3));
            Console.WriteLine();

            // Display magazine details and late fee
            magazine.DisplayItemDetails();
            Console.WriteLine("Late Fee for 3 days: " + magazine.CalculateLateFee(3));
            Console.WriteLine();

            /*
            TASK 2 & 4:
            Interface method calls using interface references
            */
            IReservable reservableBook = book;
            reservableBook.ReserveItem();

            INotifiable notifiableBook = book;
            notifiableBook.SendNotification("Please return the book on time.");
            Console.WriteLine();

            /*
            TASK 3: DYNAMIC POLYMORPHISM
            Method selection happens at runtime
            */
            List<LibraryItem> items = new List<LibraryItem>
            {
                book,
                magazine
            };

            foreach (LibraryItem item in items)
            {
                item.DisplayItemDetails();
                Console.WriteLine();
            }

            /*
            TASK 6: STATIC MEMBERS
            */
            LibraryAnalytics.TotalBorrowedItems += 5;
            LibraryAnalytics.DisplayAnalytics();
            Console.WriteLine();

            /*
            TASK 7: ENUM USAGE
            */
            Users.Member member = new Users.Member
            {
                Name = "Pushpam",
                Role = UserRole.Member
            };

            ItemStatus status = ItemStatus.Borrowed;

            Console.WriteLine("User Role: " + member.Role);
            Console.WriteLine("Item Status: " + status);
            Console.WriteLine();

            /*
            BONUS TASK:
            Role-based notification
            */
            if (member.Role == UserRole.Admin)
            {
                Console.WriteLine("Admin Alert: System maintenance scheduled.");
            }
            else
            {
                Console.WriteLine("Member Notification: Your borrowed item is due tomorrow.");
            }

            // Demonstrating eBook behavior
            ItemsAlias.eBook ebook = new ItemsAlias.eBook
            {
                Title = "Digital C#",
                Author = "Tech Author",
                ItemID = 301
            };

            ebook.Download();
        }
    }
}
