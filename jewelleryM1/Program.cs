using System;
using System.Collections.Generic;

class Jewellery{
    private int jewel_id;
    private string jewel_name;
    private double jewel_price;
    private double jewel_weight;
    
    public int Jewel_id{
        get { return jewel_id;}
        set {
            if( value < 0){
                Console.WriteLine("Invalid Jewellery Id");
            }else{
                jewel_id=value;
            }
        }
    }

    public string Jewel_name{
        get { return jewel_name;}
        set {
            if(string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("Invalid JewelleryName");
            }
            else{
                jewel_name= value;
            }
        }
    }
    public double Jewel_price{
        get { return jewel_price ;}
        set {
            if(value <0 ){
                throw new ArgumentException("Invalid Price");
            }
            else{
                jewel_price= value;
            }
        }
    }
    public double Jewel_weight{
        get { return jewel_weight; }
        set {
            if(value <0 ){
                throw new ArgumentException("Invalid Price");
            }
            else{
                jewel_weight= value;
            }
        }
    }

    
}

class UtilityJewellery{
     public void GetJewelleryDetails(Jewellery j){
        Console.WriteLine($"Jwellery Id: {j.Jewel_id}");
        Console.WriteLine($"Jwellery Name: {j.Jewel_name}");
        Console.WriteLine($"Jwellery Price: {j.Jewel_price}");
        Console.WriteLine($"Jwellery Weight: {j.Jewel_weight}");
     }

     public void UpdatePrice(Jewellery j, double price){
                if(price <0){
                    Console.WriteLine("This price is not acceptable");
                }else{
                    j.Jewel_price = price;

                    Console.WriteLine("Updated price is:  "+ j.Jewel_price);
                }

     }
}

class Program{
    public static void Main(){
        Jewellery j= new Jewellery();
        UtilityJewellery p1 = new UtilityJewellery();

        Console.WriteLine("Jewellery Details: ");

        Console.WriteLine("Enter JewelleryId: ");
        j.Jewel_id= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter JewelleryName: ");
        j.Jewel_name= Console.ReadLine();


        Console.WriteLine("Enter JewelleryPrice");
        j.Jewel_price=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter JewelleryWeight");
        j.Jewel_weight= Convert.ToDouble(Console.ReadLine());


    int choice;
    do{

        Console.WriteLine("Press 1 for JewelleryDetails: ");
        Console.WriteLine("Press 2 for JewelleryPriceUpdate: ");
        Console.WriteLine("Press 3 for exit and Thnak you msg: ");

        // UtilityJewellery p1 = new UtilityJewellery();
        choice = Convert.ToInt32(Console.ReadLine());
         switch(choice){
            case 1:
                p1.GetJewelleryDetails(j);
                break;
            case 2:
                Console.WriteLine("Enter the Price which you want to be Updated");
                double pr= Convert.ToDouble(Console.ReadLine());
                p1.UpdatePrice(j, pr);
                break;
            case 3:
                Console.WriteLine("Thank youuuu....");
                break;
            default:
                Console.WriteLine("Invalid number choice");
                break;
         }
    }
    while(choice!=3);
}
}