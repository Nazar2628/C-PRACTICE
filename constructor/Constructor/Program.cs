using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

/*namespace immutable;
class Str
{
    static string s;
    static string d;

     public static void Main(string[] args)
     {
        s = "NAZAR";
        d = s.Replace("NAZAR", "BASHA");
        if (object.ReferenceEquals(s,d))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
        Console.ReadLine();
        Console.ReadKey();
     }
}*/
/*using System.Text;

StringBuilder sb = new StringBuilder("WELCOME TO ", 50);
sb.Append("COGNINE TECHNOLOGIES");
Console.WriteLine(sb);*/

/*class Person
{
    public Person()
    {
        uint ik = 100;
        Console.WriteLine("Constructor called.");
    }
    ~Person()
    {
        Console.WriteLine("Destructor called.");
    }

    public static void Main(string[] args)
    {
        GC.Collect();
        Person p1 = new Person();
        Console.WriteLine(p1);
        Console.WriteLine(GC.GetGeneration(p1));
        Console.ReadLine();
    }
}*/

/*namespace boxing
{
    class Program
    {
        static void Myfunc(int param1)
        {
            // localint1 is created on the stack
            // and destroyed immediately after returning
            int localint1 = 5;
            //return ( param1 + localint1);
            Console.WriteLine(param1 + localint1);
        }
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;             // boxing  
            int j = (int)o;          // unboxing  
            Console.WriteLine("value of o object : " + o);
            Console.WriteLine("Value of j : " + j);
            Console.ReadLine();
            
            Myfunc(10);
        }
    }
}*/
namespace stat
{
    class state
    {
       public static int k = 100;

        public void ef()
        {
            Console.WriteLine(k);
        }
      
    }
    class call
    {
        public static void Main()
        {
            state l = new state();
            l.ef();
            
        }
    }
}
