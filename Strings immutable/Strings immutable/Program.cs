class Immutable
{
    static string s;
    static string k;
    public static void Main(string[] args)
    {

        s = "BASHA";
        //k = s;
        s += " SHAIK";
        s.Replace("BASHA", "NAZAR");
        Console.WriteLine(k);
        Console.WriteLine(s);
        Console.WriteLine("The number of generations are: " + GC.MaxGeneration);
        Console.ReadLine();

    }
}