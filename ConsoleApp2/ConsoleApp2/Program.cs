
using System.Runtime.Intrinsics;

class vehicle
{
    static int one=10;
    int two;
   
    public static void Main(String[] args)
    {
        vehicle v1 = new vehicle();
       
        v1.two = 50;
        Console.WriteLine(v1.two);
    }
}