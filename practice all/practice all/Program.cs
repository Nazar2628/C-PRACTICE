//using System.Threading;
//namespace practice
//{
//    //    public class complex
//    //    {
//    //        private int i;
//    //        private string k;
//    //        public complex(int l=0,string o="")
//    //        {
//    //            i = l;
//    //            k = o;
//    //        }
//    //        public static complex operator +(complex a, complex b)
//    //        {
//    //            complex o1 = new complex();
//    //            o1.i = a.i + b.i;
//    //            o1.k = a.k + b.k;
//    //            return o1;
//    //        }
//    //        public void Display()
//    //            {
//    //                Console.WriteLine($"{i},{k}");
//    //            }

//    //        public static void Main(string[] args)
//    //        {
//    //            complex a = new complex(10, "NAZAR");
//    //            a.Display();
//    //            complex b = new complex(20, "Basha");
//    //            b.Display();

//    //            complex d = a + b;
//    //            d.Display();
//    //        }


//    //    }
//    //class A  //base class
//    //{
//    //    public string msg()
//    //    {
//    //        return "this is A class Method";
//    //    }
//    //}
//    //class B : A
//    //{
//    //    public string info()
//    //    {
//    //        msg();
//    //        return "this is B class Method";
//    //    }
//    //    class C : A
//    //    {
//    //        public string getinfo()
//    //        {
//    //            Console.WriteLine(msg());
//    //            return "this is B class Method";
//    //        }
//    //    }
//    //    class en
//    //    {
//    //        private int s;
//    //        public int S { get { return s; } set { s = value; } }

//    //        public static void Main(string[] args)
//    //        {
//    //            //A a = new A();
//    //            //a.msg();

//    //            en c = new en();
//    //            c.S = 2154;
//    //            Console.WriteLine(c.S);
//    //        }
//    //    }
//    // class threading
//    //{
//    //    public static void loop1()
//    //    {
//    //        int i;
//    //        for (i = 0; i <= 10; i++)
//    //        {
//    //            Console.WriteLine("count1 = {0}", i);
//    //            Thread.Sleep(100);
//    //        }

//    //    }
//    //    public static void loop2()
//    //    {
//    //        int i;
//    //        for (i = 10; i >= 0; i--)
//    //        {
//    //            Console.WriteLine("count2 = {0}", i);
//    //            Thread.Sleep(100);
//    //        }

//    //    }
//    //    public static void Main(string[] args)
//    //    {
//    //        Thread t = new Thread(loop1);
//    //        Thread k = new Thread(loop2);
//    //        t.Start();
//    //        k.Start();


//    //    }
//    //}
//        public class AssemblyOneClass1
//        {
//            internal int Id;
//            public void Display1()
//            {
//                //internal Members Accessible with the Containing Type 
//                //Where they are created
//                Console.WriteLine(Id);
//            }
//        }
//        public class AssemblyOneClass2 : AssemblyOneClass1
//        {
//            public void Display2()
//            {
//                //We can access internal Members from Derived Classes
//                //Within the Same Assembly
//                Console.WriteLine(Id); //No-Compile Time Error
//            }
//        }

//    public class AssemblyOneClass3
//    {
//        public void Dispplay3()
//        {
//            //We can access internal Members from Non-Derived Classes
//            //Within the Same Assembly
//            AssemblyOneClass1 obj = new AssemblyOneClass1();
//            Console.WriteLine(obj.Id); //No-Compile Time Error
//        }
//        public static void Main(string[] args)
//        {
//            AssemblyOneClass3 obj = new AssemblyOneClass3();
//            obj.Dispplay3();
//        }
//    }
//}

// C# Program to demonstrate
// the Object class
//using System;
//using System.Text;

//class Geeks
//{

//    // Main Method
//    static void Main(string[] args)
//    {
//        Object obj1 = new Object();
//        obj1 = 121;
//        obj1 = "kjjdfn";
//        Geeks j = new Geeks();
//        Geeks obj2 = new Geeks();
//        //obj1=j;
//        //bool b = obj1.Equals(obj3);
//        //Console.WriteLine(b);
//        //Console.ReadKey();
//        // taking object type

//        // taking integer
//        int i = 10;
//        Console.WriteLine(obj1);
//        // taking Type type and assigning
//        // the value as type of above
//        // defined types using GetType
//        // method
//        Type t1 = obj1.GetType();
//        Type t2 = i.GetType();
//        Console.WriteLine(t1);  
//        Console.WriteLine(t2);
//        //Geeks obj2 = new Geeks();
//        //Console.WriteLine(obj2.BaseType);
//        // Displaying result

//        Console.WriteLine("For Object obj1 = new Object();");

//        // BaseType is used to display
//        // the base class of current type
//        // it will return nothing as Object
//        // class is on top of hierarchy
//        Console.WriteLine(t1.BaseType);

//        // It will return the name class
//        Console.WriteLine(t1.Name);

//        // It will return the
//        // fully qualified name
//        Console.WriteLine(t1.FullName);

//        // It will return the Namespace
//        // By default Namespace is System
//        Console.WriteLine(t1.Namespace);

//        Console.WriteLine();

//        Console.WriteLine("For String str");

//        // BaseType is used to display
//        // the base class of current type
//        // it will return System.Object
//        // as Object class is on top
//        // of hierarchy
//        Console.WriteLine(t2.BaseType);

//        // It will return the name class
//        Console.WriteLine(t2.Name);

//        // It will return the
//        // fully qualified name
//        Console.WriteLine(t2.FullName);

//        // It will return the Namespace
//        // By default Namespace is System
//        Console.WriteLine(t2.Namespace);
//        Console.ReadKey();
//    }
//}


///// ABSTRACTION
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Transaction doing SBI Bank");
//        IBank sbi = BankFactory.GetBankObject("SBI");
//        sbi.ValidateCard();
//        sbi.WithdrawMoney();
//        sbi.CheckBalanace();
//        sbi.BankTransfer();
//        sbi.MiniStatement();
//        Console.WriteLine("\nTransaction doing AXIX Bank");
//        IBank AXIX = BankFactory.GetBankObject("AXIX");
//        AXIX.ValidateCard();
//        AXIX.WithdrawMoney();
//        AXIX.CheckBalanace();
//        AXIX.BankTransfer();
//        AXIX.MiniStatement();
//        Console.Read();
//    }
//}
//public abstract class IBank
//{
//    public abstract void ValidateCard();
//    public abstract void WithdrawMoney();
//    public abstract void CheckBalanace();
//    public abstract void BankTransfer();
//    public abstract void MiniStatement();
//}
//public class BankFactory
//{
//    public static IBank GetBankObject(string bankType)
//    {
//        IBank BankObject = null;
//        if (bankType == "SBI")
//        {
//            BankObject = new SBI();
//        }
//        else if (bankType == "AXIX")
//        {
//            BankObject = new AXIX();
//        }
//        return BankObject;
//    }
//}
//public class SBI : IBank
//{
//    public override void BankTransfer()
//    {
//        Console.WriteLine("SBI Bank Bank Transfer");
//    }
//    public override void CheckBalanace()
//    {
//        Console.WriteLine("SBI Bank Check Balanace");
//    }
//    public override void MiniStatement()
//    {
//        Console.WriteLine("SBI Bank Mini Statement");
//    }
//    public override void ValidateCard()
//    {
//        Console.WriteLine("SBI Bank Validate Card");
//    }
//    public override void WithdrawMoney()
//    {
//        Console.WriteLine("SBI Bank Withdraw Money");
//    }
//}
//public class AXIX : IBank
//{
//    public override void BankTransfer()
//    {
//        Console.WriteLine("AXIX Bank Bank Transfer");
//    }
//    public override void CheckBalanace()
//    {
//        Console.WriteLine("AXIX Bank Check Balanace");
//    }
//    public override void MiniStatement()
//    {
//        Console.WriteLine("AXIX Bank Mini Statement");
//    }
//    public override void ValidateCard()
//    {
//        Console.WriteLine("AXIX Bank Validate Card");
//    }
//    public override void WithdrawMoney()
//    {
//        Console.WriteLine("AXIX Bank Withdraw Money");
//    }
//}
//class met 
//{


//    public int method1()
//    {
//        int a = 100;

//    }
//    public int method2(ref a)
//    {
//        int b = a+ 2;
//        return b;
//    }
//    public static void Main(String[] args)
//    {
//        met met = new met();
//        Console.WriteLine( met.method2());
//    }
//}


//using System;
//namespace Polymorphism
//{
//    class A
//    {
//        public void Test() { Console.WriteLine("A::Test()"); }
//    }

//    class B : A
//    {
//        public new void Test() { Console.WriteLine("B::Test()"); }
//    }

//    class C : B
//    {
//        public new void Test() { Console.WriteLine("C::Test()"); }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            A a = new A();
//            B b = new B();
//            C c = new C();

//            a.Test(); // output --> "A::Test()"
//            b.Test(); // output --> "B::Test()"
//            c.Test(); // output --> "C::Test()"

//            a = new B();
//            a.Test(); // output --> "A::Test()"

//            b = new C();
//            b.Test(); // output --> "B::Test()"

//            Console.ReadKey();
//        }
//    }
//}


//using Extention;
//using Extention1;

//namespace Extention
//{
//    public class ExDemo
//    {
//        public void ex1()
//        {
//            Console.WriteLine("Main Class Method");
//        }
//    }

//}

//namespace Extention1
//{
//    public static class Extention1
//    {
//        public static void extension1(this ExDemo ex)
//        {
//            Console.WriteLine("Extented Class");
//        }
//    }
//}

//namespace Result
//{
//    class A : ExDemo
//    {
//        public void extented()
//        {
//            Console.WriteLine();
//        }
//        public static void Main (string[] args)
//        {
//            A obj1 = new A();
//            obj1.extension1();
//        }
//    }
//}


//using System.IO;
//using System.IO.Pipes;
//using System.Text;

//namespace System.IO
//{
//    class FileStream1
//    {
//        public static void Main(string[] args)
//        {
//            FileStream fs = new FileStream(@"D:", FileAccess.Read);
//            //using (StreamWriter writer = new StreamWriter(fs))
//            //{
//            //    writer.Write("Sample Text ");
//            //}
//            byte[] bdata = Encoding.Default.GetBytes("wriiting in a file");
//            fs.Write(bdata, 0, bdata.Length);
//            fs.Close();
//        }
//    }
//}
//namespace Array
//{
//    class Array
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 3, 95, 99, 35, 9 };
//            int[] array1 = { 2, 35, 35, 648, 3, 5 };
//            var combinedList = new List<int>();
//            combinedList.AddRange(array);
//            combinedList.AddRange(array1);
//            Console.WriteLine(array.Concat(array1).ToArray());
//            foreach (int a in (array.Concat(array1)))
//            {
//                Console.Write(a+" ");
//            }
//        }
//    }

//}


//namespace OptionalParameter
//{
//    class CheckingOptionalParamete
//    {
//        public void CheckingOptionalParameter(int b, [Optional] int c)
//        {
//            Console.WriteLine("optional");

//        }

//        public void CheckingOptionalParameter(int a)
//        {
//            Console.WriteLine("first");
//        }

//        public void CheckingOptionalParameter(int x,int y,int z)
//        {
//            Console.WriteLine(x+y+z);
//            Console.WriteLine(x);
//        }



//        public static void Main(string[] args)
//        {
//           CheckingOptionalParamete checking=new CheckingOptionalParamete();
//            checking.CheckingOptionalParameter(1);
//            checking.CheckingOptionalParameter(y:2,x:3,z:5);

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//namespace GenericCollections
//{
//    public class GenericSortedDictionaryDemo
//    {
//        public static void Main(string[] args)
//        {
//            LinkedList<string> linkedList = new LinkedList<string>();
//            linkedList.AddLast("One");
//            linkedList.AddLast("Two");
//            linkedList.AddLast("Three");
//            linkedList.AddLast("Four");
//            linkedList.AddFirst("Five"); //Added to first index
//            Console.WriteLine("SortedDictionary Elements: ");
//            foreach (var item in linkedList)
//            {
//                Console.WriteLine($"{item} ");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//namespace GenericCollections
//{
//    public class GenericSortedListDemo
//    {
//        public static void Main(string[] args)
//        {
//            SortedList<int, string> sortedList = new SortedList<int, string>();
//            sortedList.Add(1, "One");
//            sortedList.Add(5, "Five");
//            sortedList.Add(2, "Two");
//            sortedList.Add(4, "Four");
//            sortedList.Add(3, "Three");


//            Console.WriteLine("SortedList Elements: ");
//            foreach (KeyValuePair<int, string> kvp in sortedList)
//            {
//                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//namespace GenericCollections
//{
//    public class GenericSortedDictionaryDemo
//    {
//        public static void Main(string[] args)
//        {
//            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
//            sortedDictionary.Add(1, "One");
//            sortedDictionary.Add(5, "Five");
//            sortedDictionary.Add(2, "Two");
//            sortedDictionary.Add(4, "Four");
//            sortedDictionary.Add(3, "Three");
//            sortedDictionary.Remove(1);

//            Console.WriteLine("SortedDictionary Elements: ");
//            foreach (KeyValuePair<int, string> i in sortedDictionary)
//            {
//                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//namespace GenericCollections
//{
//    public class GenericDictionaryDemo
//    {
//        public static void Main(string[] args)
//        {
//            Dictionary<int, string> dictionary = new Dictionary<int, string>();
//            dictionary.Add(1, "One");
//            dictionary.Add(2, "Two");
//            dictionary.Add(3, "Three");
//            dictionary.Add(4, "Four");
//            dictionary.Add(5, "Five");

//            Console.WriteLine("Dictionary Elements: ");
//            foreach (KeyValuePair<int, string> i in dictionary)
//            {
//                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");

//            }
//            Console.WriteLine(dictionary);
//            Console.ReadKey();
//        }
//    }
//}

using System.Reflection;

//namespace Enum
//{
//    class EnumExample
//    {
//        enum Months
//        {
//            january=1,feb,mar,apr,may=150,jun=162,jul,aug,sep,oct,nov,dec
//        }
//        public static void Main(string[] args)
//        {
//            EnumExample example = new EnumExample();
//            Console.WriteLine((int)Months.oct);
//            int[] Values = (int[])Months.GetValues(typeof(Months));
//            foreach (int value in Values)
//            {
//                Console.WriteLine(value);
//            }
//            Console.WriteLine(Months.jun);
//        }
//    }
//}

[Flags]
public enum Days
{
    None = 0b_0000_0000,  // 0
    Monday = 0b_0000_0001,  // 1
    Tuesday = 0b_0000_0010,  // 2
    Wednesday = 0b_0000_0100,  // 4
    Thursday = 0b_0000_1000,  // 8
    Friday = 0b_0001_0000,  // 16
    Saturday = 0b_0010_0000,  // 32
    Sunday = 0b_0100_0000,  // 64
    Weekend = Saturday | Sunday
}

public class FlagsEnumExample
{
    public static void Main()
    {
        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine(meetingDays);
        // Output:
        // Monday, Wednesday, Friday

        Days workingFromHomeDays = Days.Thursday | Days.Friday;
        Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
        // Output:
        // Join a meeting by phone on Friday

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
        // Output:
        // Is there a meeting on Tuesday: False

        var a = (Days)5;
        Console.WriteLine(a);
        // Output:
        // Monday, Wednesday, Saturday
    }
}