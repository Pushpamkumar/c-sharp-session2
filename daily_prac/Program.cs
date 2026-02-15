using System;
using System.Collections.Generic;


class Book{
    public string Id{set; get;}
    public string BookTitle{set; get;}
    public string Author{set; get;}
    public int Price{set; get;}
    public int Stock{set; get;}

}
class BookUtility{
    public void GetBookDetails(Book b){
        Console.WriteLine("Books Details: ");
        Console.WriteLine($"BookId: {b.Id}");
        Console.WriteLine($"BookTitle: {b.BookTitle}");
        Console.WriteLine($"BookPrice: {b.Price}");
        Console.WriteLine($"BookStock: {b.Stock}");
    }
    public void UpdateBookPrice(Book b, int newPrice){
                if(newPrice <0){
                    throw new Exception("Invalid BookPrice");
                }else{
                    b.Price=newPrice;
                }
            Console.WriteLine($"Updated BookPrice is: {b.Price}");
    }
    public void UpdateBookStock(Book b, int newStock){
            if(newStock <0){
                    throw new Exception("Invalid BookStock");
                }else{
                    b.Stock=newStock;
                }
            Console.WriteLine($"Updated BookStock: {b.Stock}");
    }
}
class Program{
    public static void Main(){

        Book m= new Book();
        Console.WriteLine("-----------Book Store Application--------------");
        Console.WriteLine("Enter Book ID: ");
        m.Id=Console.ReadLine();
        Console.WriteLine("Enter Book Title: ");
        m.BookTitle=Console.ReadLine();

        Console.WriteLine("Enter Book Author: ");
        m.Author=Console.ReadLine();
        Console.WriteLine("Enter Book Price: ");
        m.Price=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Book Stock: ");
        m.Stock=Convert.ToInt32(Console.ReadLine());


        BookUtility m1= new BookUtility();
            



        int choice;
        do{
            Console.WriteLine("-------Menu choices---------");
            Console.WriteLine("Press 1: Display Book Details");
            Console.WriteLine("Press 2: Update the Price");
            Console.WriteLine("Press 3: Update the Stock");
            Console.WriteLine("Press 4: Exit");

            choice=Convert.ToInt32(Console.ReadLine());

            try {

            switch(choice)
            {
                case 1:
                    m1.GetBookDetails(m);
                    break;
                case 2:
                    Console.WriteLine("Enter Updated price: ");
                    int p=Convert.ToInt32(Console.ReadLine());
                    m1.UpdateBookPrice(m,p);
                    break;
                case 3:
                    Console.WriteLine("Enter Updated Stock: ");
                    int s=Convert.ToInt32(Console.ReadLine());
                    m1.UpdateBookStock(m,s);
                    break;
                case 4:
                    Console.WriteLine("Thank you.....");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            }
            catch(Exception ex){
                Console.WriteLine($"Error message: {ex.Message}");
            }
            


        }
        while(choice!=4);


    }
}