using System;    
using System.Collections.Generic;
// --------1-----------                               // TODO: needed for Console

// public class Program                              // Boilerplate: Program class
// {
//     public static void Main()                      // Entry point
//     {
//         int a = 10;                                // Example value
//         int b = 20;                                // Example value

//         Swap<int>(ref a, ref b);                   // Calling generic swap

//         Console.WriteLine($"a={a}, b={b}");         // Expected: a=20, b=10

//         string x = "Gopi";                          // Example string
//         string y = "Suresh";                        // Example string

//         Swap(ref x, ref y);                         // Generic type inference works too
//         Console.WriteLine($"x={x}, y={y}");         // Expected: x=Suresh, y=Gopi
//     }

//     // ✅ TODO: Students must implement only this function
//     public static void Swap<T>(ref T left, ref T right)
//     {
//         // TODO: Swap values using a temporary variable
//         T temp= left;
//         left = right;
//         right = temp;

//     }
// }

// ---------------------2----------------


// using System;                                     // Console
// using System.Collections.Generic;                 // List<T>

// public class Program
// {
//     public static void Main()
//     {
//         var intRepo = new SimpleRepo<int>();       // Repo for int
//         intRepo.Add(10);
//         intRepo.Add(20);

//         Console.WriteLine(string.Join(",", intRepo.GetAll())); // Expected: 10,20

//         var nameRepo = new SimpleRepo<string>();   // Repo for string
//         nameRepo.Add("Asha");
//         nameRepo.Add("Vikram");

//         Console.WriteLine(string.Join(",", nameRepo.GetAll())); // Expected: Asha,Vikram
//     }
// }

// public class SimpleRepo<T>
// {
//     private readonly List<T> _items = new();       // In-memory storage

//     // ✅ TODO: Students implement this
//     public void Add(T item)
//     {
//         // TODO: Add item into _items
//         _items.Add(item);
//     }

//     // ✅ TODO: Students implement this
//     public IReadOnlyList<T> GetAll()
//     {
//         // TODO: Return all items as read-only list
//         return _items.AsReadOnly;
//     }
// }

// --------------3-------------------


// using System;

// public class Program
// {
//     public static void Main()
//     {
//         var cache = new RefCache<string>();         // ✅ Allowed (string is class)
//         cache.Set(null);                            // Store null
//         Console.WriteLine(cache.GetOrDefault("NA")); // Expected: NA

//         cache.Set("Hello");
//         Console.WriteLine(cache.GetOrDefault("NA")); // Expected: Hello

//         // var wrong = new RefCache<int>();          // ❌ Should not compile because int is a struct
//     }
// }

// public class RefCache<T> where T : class            // Constraint: only reference type
// {
//     private T? _value;                              // Nullable reference

//     public void Set(T? value)
//     {
//         _value = value;                             // Save value
//     }

//     // ✅ TODO: Students implement this
//     public T GetOrDefault(T defaultValue){

        //  if (_value == null)
        //     {
        //         return defaultValue;
        //     }

        //     return _value;}
//     
//         // TODO: if _value is null, return defaultValue, else return _value
    
//     
// }

// ----------------------4------------------------

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine(Apply(5, 3, (a, b) => a + b));    // Expected: 8
//         Console.WriteLine(Apply(5, 3, (a, b) => a * b));    // Expected: 15
//         Console.WriteLine(Apply("Hi", "Tech", (a, b) => a + " " + b)); // Expected: Hi Tech
//     }

//     // ✅ TODO: Students implement only this function
//     public static T Apply<T>(T x, T y, Func<T, T, T> op)
//     {
//         // TODO: call op and return the result
    // return op(x,y);

//         return default!;
//     }
// }



// -------------------------5-------------------


// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main()
//     {
//         var nums = new List<int> { 2, 5, 8, 11, 14 };

//         var evens = Filter(nums, n => n % 2 == 0);
//         Console.WriteLine(string.Join(",", evens));         // Expected: 2,8,14

//         var big = Filter(nums, n => n >= 10);
//         Console.WriteLine(string.Join(",", big));           // Expected: 11,14
//     }

//     // ✅ TODO: Students implement only this function
//     public static List<T> Filter<T>(List<T> items, Predicate<T> match)
//     {
//         // TODO: return a new list with matched items
//                     List<T> result = new List<T>();
//                     foreach (T item in items){
//                     if (match(item))
//                     {
//                         result.Add(item);
//                     }
//                 }

//                 return result;
//     }
// }

// ----------------------------6--------------------------

// class Reverse{
//     public string Rev(string input){
//         char [] t= input.ToCharArray();
//         int n=0;
//         int m=input.Length-1;
//         while(n<m){
//             char temp =t[n];
//             t[n]=t[m];
//             t[m]=temp;
//             n++;
//             m--;
//         }
//         return new string(t);
//     }
// }

// class Program{

//     public static void Main(){
//         Console.WriteLine("Enter String: ");
//         string a= Console.ReadLine();
//         Reverse m1= new Reverse();
//         string m2= m1.Rev(a);
//         Console.WriteLine(m2);

//     }

// }

// -------------Anamarm-----------------
// class Ana{
//     public void M1(string input, string input2){
//         if(input.Length != input2.Length){
//             Console.WriteLine("Not");
//             return;
//         }
//         int m=input.Length;
//         Dictionary <char, int> push= new Dictionary<char, int>();
//         foreach( var x in input){
//             if(push.ContainsKey(x)){
//                 push[x]++;

//             }else{
//                 push[x]=1;
//             }
//         }
//         foreach( var y in input2){
//             if(!push.ContainsKey(y)){
//                 Console.WriteLine("Not");
//             }
//             push[y]--;
//             if(push[y]==0){
//                 push.Remove(y);
//             }
            
//         }
//         if(push.Count==0){
//             Console.WriteLine("Yes");
//         }
//         else{
//             Console.WriteLine("No");
//         }

//     }
// }

// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter Please 1st");
//         string a= Console.ReadLine();
//         Console.WriteLine("Enter Please 2nd");
//         string b= Console.ReadLine();
//         Ana pu= new Ana();
//         pu.M1(a,b);
//     }
// }

// -----------------------------5-----------------------


// class T{
//     public void st(string input){
//         string [] arr= input.Split(' ');
//         string res="";
//         foreach(var x in arr){
//             char [] arr1= x.ToCharArray();
//             Array.Reverse(x);
//             res += new string(x)+" ";
//             }

//         res=res.Trim();
//         Console.WriteLine(res);
//     }
// }
// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter string: ");
//         string a=Console.ReadLine();
//         T push= new T();
//         push.st(a);

//     }
// }


// ---------------------------6---------------------------


// class Largee{
//     public void Long1(string input){
//         string [] word= input.Split(' ');
//         int max=0;
//         int le=input.Length;
//         string re="";
//         foreach(var x in word){
//             if(x.Length > max){
//                 max=x.Length;
//                 re=x;
//             }
//         }
//         Console.WriteLine(re);
//          Console.WriteLine(max);

//     }
// }

// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter input");
//         string m1=Console.ReadLine();
//         Largee m2= new Largee();
//         m2.Long1(m1);
//     }
// }
// ----------------------------------------

// class Compress{
//     public void Com(string input){
//         int a= input.Length;
//         Dictionary <char,int> push= new Dictionary<char, int>();
//         foreach( var x in input){
//             if(push.ContainsKey(x)){
//                 push[x]++;
//             }else{
//                 push[x]=1;
//             }
//         }
//         foreach( var x in push){
//             Console.Write($"{x.Key}{x.Value}");
//         }
//     }
// }

// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter string");
//         string a=Console.ReadLine();
//         Compress m1= new Compress();
//         m1.Com(a);
//     }
// }

// ----------------------------dee----------------------


// class Digit{
//     public int Str(string input){
//         string [] aa= input.Split(' ');
//         int c=0;
//         foreach(var x in aa){
//                 c++;
//         }
//         return c;
//     }
// }
// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter string");
//         string a=Console.ReadLine();
//         Digit m1= new Digit();
//         int pp=m1.Str(a);
//         Console.WriteLine(pp);
//     }
// }

// -------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter string:");
//         string input = Console.ReadLine() ?? "";

//         Console.WriteLine("Substrings:");

//         for (int i = 0; i < input.Length; i++)
//         {
//             for (int len = 1; len <= input.Length - i; len++)
//             {
//                 string sub = input.Substring(i, len);
//                 Console.Write(sub + " ");
//             }
//         }
//     }
// }

// ------------------------------------

// class Even{
//     public List<int> push(int [] arr){
//         List<int> count= new List<int>();
//         foreach( var x in arr){
//             if(x%2!=0){
//                 count.Add(x);
//             }
//         }
//         return count;

//     }
// }

// class Program{
//     public static void Main(){
//         int n=Convert.ToInt32(Console.ReadLine());
//         int [] ar=new int[n];
//         for(int i=0;i<n;i++){
//             ar[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Even m= new Even();
//         List<int> raja = m.push(ar);

//         foreach( var x in raja){
//             Console.WriteLine($"{x}");
//         }
//     }
// }


// ------------------------------
