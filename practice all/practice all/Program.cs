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
class met 
{
   

    public int method1()
    {
        int a = 100;
        ref a;
        
    }
    public int method2(ref a)
    {
        int b = a+ 2;
        return b;
    }
    public static void Main(String[] args)
    {
        met met = new met();
        Console.WriteLine( met.method2());
    }
}

