using System;
using System.Collections.Generic;
class Rev{
    public List<int> Papa(int [] arr){
        int n=arr.Length-1;
        int m=0;
        List<int> raja = new List<int>();
        while(m<n){
            int temp=arr[m];
            arr[m]=arr[n];
            arr[n]=temp;
            m++;
            n--;
        }
        for(int i=0;i<n;i++){
            papa.Add(arr[i]);
        }

        return papa;
    }
}

class Program{
    public static void Main(){
        Console.WriteLine("Enter the size:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the array:");
        int []push= new int[a];
        for(int i=0;i<a;i++){
            push[i]=Convert.ToInt32(Console.ReadLine());
        }
        Rev m= new Rev();
        List<int> ra= m.papa(push);
        foreach( var x in ra){
            Console.WriteLine(x);
        }
    }
}