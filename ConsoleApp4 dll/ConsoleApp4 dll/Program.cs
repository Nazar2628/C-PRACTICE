namespace CsharpClassLibrary
{
    public class Calculator
    {
        //int x = 200;
        //int y = 210;
        public int Calculate()
        {
            int a = 10, b = 20;
            int c = a + b;
            return c;
        }
        public  int Calculate2()
        {
            int a = 100, b = 20;
            int c = a - b;
            return c;
        }
        public static void Main()
        {

            Calculator calculator = new Calculator();
            calculator.Calculate();
            calculator.Calculate2();
            Console.ReadLine();
        }
    }
}