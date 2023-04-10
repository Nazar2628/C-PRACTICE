class IsAndAs
{
    object variable1;

    public static void Main(string[] args)
    {
        IsAndAs isAndAs = new IsAndAs();
        isAndAs.variable1 = Console.ReadLine();
        bool isOperator = isAndAs.GetType() == typeof(IsAndAs);
        bool isOperator1 = isAndAs.variable1.GetType() == typeof(string);
        Console.WriteLine(isOperator);
        Console.WriteLine(isOperator1);
    }
    //public void AsOperator(object one,)
    //{

    //}
    
}
