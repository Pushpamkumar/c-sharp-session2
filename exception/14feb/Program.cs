using System;
class Reverse{

    public string rev(string input){
        char [] arr= input.ToCharArray();
        int a=0;
        int b=input.Length-1;
        while(a<b){
            char temp=arr[a];
            arr[a]=arr[b];
            arr[b]=temp;
            a++;
            b--;
        }
        return new string(arr);
    }
}

class Program{
    public static void Main(){
        Reverse n=new Reverse();
        Console.WriteLine("Enter String :");
        string b=Console.ReadLine();
        string push=n.rev(b);
        Console.WriteLine(push);
    }
}