//String And StringBuilder

using System.Text;

class StringAndStringBuilder
{
    // Concatenates to String
    public static void Concat1(String s1)
    {

        String st = " Technologies";
        s1+=st;

    }

    // Concatenates to StringBuilder
    public static void Concat2(StringBuilder s2)
    {
        s2.Append(" Technologies");
    }

    public static void Main(String[] args)
    {

        String s1 = "Cognine";
        Console.WriteLine("Hashcode of S1 before concat  {0}", s1.GetHashCode());
        Concat1(s1);
        Console.WriteLine("Using String Class: " + s1);
        Console.WriteLine("Hashcode of S1 after concat  {0}", (s1 + " Technologies").GetHashCode());


        StringBuilder s2 = new StringBuilder("Cognine");
        Console.WriteLine("Hashcode of S2 before concat : {0}", s2.GetHashCode());
        Concat2(s2);
        Console.WriteLine("Using StringBuilder Class: " + s2);
        Console.WriteLine("Hashcode of S2 after concat : {0}", (s2).GetHashCode());


    }
}


//class CopyToAndClone
//{
//    static void Main()
//    {

//        string[] arr = new[] { "1", "2", "3", "4", "5" };
//        string[] arr2 = new string[6];
//        arr.CopyTo(arr2, 0);
//        arr2.Append("8");

//        // cloning arr and storing it in new array
//        string[] new_arr = (string[])arr.Clone();
//        new_arr[0] = "7";

//        // Printing array using loop
//        foreach (var element in arr2)
//        {
//            System.Console.WriteLine(element);
//        }
//        Console.WriteLine(arr[0].GetHashCode());
//        Console.WriteLine(arr2[0].GetHashCode());

//        Console.WriteLine(new_arr.Length);

//    }
//}

//class ArrayParameter
//{

//    public int SumOfArr(int[] arr)
//    {
//        int sum = 0;
//        foreach (int i in arr)
//        {
//            sum += i;
//        }
//        return sum;
//    }

//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3 };
//        ArrayParameter arrayParameter= new ArrayParameter();

//        Console.WriteLine( arrayParameter.SumOfArr(arr));
//    }
//}

//using System;
//public class MyClass : ICloneable
//{
//    public int Value;
//    public MyClass(int value)
//    {
//        Value = value;

//    }

//    public object Clone()
//    {
//        return new MyClass(Value);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass obj1 = new MyClass(10);
//        MyClass obj2 = (MyClass)obj1.Clone();



//        Console.WriteLine($"obj1.Value = {obj1.Value}");
//        Console.WriteLine($"obj2.Value = {obj2.Value}");



//        obj1.Value = 20;



//        Console.WriteLine($"obj1.Value = {obj1.Value}");
//        Console.WriteLine($"obj2.Value = {obj2.Value}");
//    }
//}

//class CopyToAndClone
//{
//    static void Main()
//    {

//        string[] arr = new[] { "1", "2", "3", "4", "5" };
//        string[] arr2 = new string[6];
//        arr.CopyTo(arr2, 0);


//        // cloning arr and storing it in new array
//        string[] new_arr = (string[])arr.Clone();
//        //new_arr[0] = "7";
//        arr[0] = "10";

//        // Printing array using loop
//        foreach (var element in new_arr)
//        {
//            System.Console.WriteLine(element);
//        }
//        Console.WriteLine(arr[0].GetHashCode());
//        Console.WriteLine(arr2[0].GetHashCode());

//        Console.WriteLine(new_arr.Length);

//    }
//}


//class ArrayAtRuntime
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4 };
//        Type elementType = typeof(int);
//        int length = 10;
//        Array array = Array.CreateInstance(elementType, length);
//        arr.CopyTo(array, 0);
//        foreach (int i in array)
//        {
//            Console.WriteLine(i);
//        }
//        Console.WriteLine(array.Length);
//        Console.WriteLine(array.GetType());
//    }
//}