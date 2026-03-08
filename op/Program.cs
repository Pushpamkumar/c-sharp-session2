using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(int id, string title, string author, double price)
    {
        BookId = id;
        Title = title;
        Author = author;
        Price = price;
    }
}

class DuplicateBookException : Exception
{
    public DuplicateBookException(string msg) : base(msg) { }
}

class InvalidPriceException : Exception
{
    public InvalidPriceException(string msg) : base(msg) { }
}

class BookNotFoundException : Exception
{
    public BookNotFoundException(string msg) : base(msg) { }
}

class LibraryUtility
{
    private Dictionary<int, Book> books = new Dictionary<int, Book>();

    public void AddBook(Book b)
    {
        // TODO
        if(books.ContainsKey(b.BookId)){
            throw new DuplicateBookException("Duplicate book found");
        }
        if(b.Price<=0){
            throw new InvalidPriceException("Invalid price");
        }
        books.Add(b.BookId, b);
    }

    public void UpdatePrice(int id, double price)
    {
        // TODO
        if(price <=0){
            throw new InvalidPriceException("Invalid price");
        }
        if(books.ContainsKey(id)){
            books[id].Price= price;
        }else{
            throw new BookNotFoundException("Invalid books not found");
        }
    }

    public List<Book> GetAllBooks()
    {
        return books.Values.ToList();
    }
}

class Program
{
    static void Main()
    {
        LibraryUtility util = new LibraryUtility();

        while (true)
        {
            Console.WriteLine("1 Add Book");
            Console.WriteLine("2 Update Price");
            Console.WriteLine("3 Display Books");
            Console.WriteLine("4 Exit");

            int ch = int.Parse(Console.ReadLine());

            try
            {
                switch (ch)
                {
                    case 1:
                        int id = int.Parse(Console.ReadLine());
                        string title = Console.ReadLine();
                        string author = Console.ReadLine();
                        double price = double.Parse(Console.ReadLine());

                        Book b = new Book(id, title, author, price);
                        util.AddBook(b);
                        Console.WriteLine("Book Added");
                        break;

                    case 2:
                        int bid = int.Parse(Console.ReadLine());
                        double p = double.Parse(Console.ReadLine());

                        util.UpdatePrice(bid, p);
                        Console.WriteLine("Price Updated");
                        break;

                    case 3:
                        List<Book> list = util.GetAllBooks();

                        foreach (var bk in list)
                        {
                            Console.WriteLine(
                                $"{bk.BookId} {bk.Title} {bk.Author} {bk.Price}"
                            );
                        }
                        break;

                    case 4:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
