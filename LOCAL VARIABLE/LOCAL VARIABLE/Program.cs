using System.Security.Cryptography.X509Certificates;
using dll;
class Local 
{
    string x;
    string y;
    
    public static void Main()
    {
        Local o = new Local();
        o.x = Console.ReadLine();
        o.y= Console.ReadLine();   
        
        int k;
        int j;
        k=Convert.ToInt32(o.x);
        j=Convert.ToInt32(o.y);

        Class1 math = new Class1();
        int add = math.add(k, j);
        int sub =math.sub(k, j);


        Console.WriteLine(add);
        Console.WriteLine(sub);
    }
}