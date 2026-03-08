using System;
using System.Collections.Generic;
using System.Linq;

// class Merge{
//     public List<int> M(List<int> temp, List<int> raj){
//         List<int> push= new List<int>();

//         int m=0;
//         int n=0;
//         while(m< temp.Count && n < raj.Count){
//             if(temp[m]<raj[n]){
//                 push.Add(temp[m++]);
//             }else{
//                 push.Add(raj[n++]);
//             }
//         }

//         while(m<temp.Count) {
//             push.Add(temp[m++]);
//         }
//         while(n<raj.Count) {
//             push.Add(raj[n++]);
//         }

//         return push;


//     }
// }


// class Program{
//     public static void Main(){
//         int n=Convert.ToInt32(Console.ReadLine());
//         int [] ar=new int[n];
//         for(int i=0;i<n;i++){
//             ar[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Enter second List: ");
//         int [] arr=new int[n];
//         for(int i=0;i<n;i++){
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Merge m= new Merge();
//         List<int> raja = m.M(ar.ToList(), arr.ToList());
//          Console.WriteLine("Elements are: ");
//         foreach( var x in raja){
//             Console.Write($"{x} ");
//         }

//     }
// }


// ----------------------

// List<int> num = new List<int>{10,5,30};

// var result = num.Distinct().OrderByDescending(x=>x).Skip(1).First();

// Console.WriteLine(result);
