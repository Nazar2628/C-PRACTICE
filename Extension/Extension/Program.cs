using CountOfSubString;
namespace ExtensionMethod1
{
    public static class Extension
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
        //public static void Main(string[] args)
        //{
        //    Class1 ob = new Class1();
        //    ob.SubCount("sdhbfhjdb","hb");
        //    ob.NewMethod();
        //}
    }
    class asinherit : Class1
    {
        public static void Main(string[] args)
        {
            asinherit k = new asinherit();
            k.SubCount("jhregfbhe", "fb");
        }
    }
   
    
}