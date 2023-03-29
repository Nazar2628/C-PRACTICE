// C# program to demonstrate the working
// of Unary Arithmetic Operators
using System;
namespace Arithmetic
{

    /*class GFG
    {

        // Main Function
        static void Main(string[] args)
        {

            int a = 10, res;

            // post-increment example:
            // res is assigned 10 only,
            // a is not updated yet
            res = a++;

            //a becomes 11 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // post-decrement example:
            // res is assigned 11 only, a is not updated yet
            res = a--;

            //a becomes 10 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-increment example:
            // res is assigned 11 now since a
            // is updated here itself
            res = ++a;

            // a and res have same values = 11
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-decrement example:
            // res is assigned 10 only since
            // a is updated here itself
            res = --a;

            // a and res have same values = 10
            Console.WriteLine("a is {0} and res is {1}", a, res);
             


        }
    }*/
    /*class wises
    {
        public static void Main(string[] args)
        {
            int a = 9;
            int b = 1;
            Console.WriteLine(a>>b);
        }
    }*/
    class Program
    {
        int i = 10;
        static void Main(string[] args)
        {

            Console.Write("Enter the Decimal Number : ");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Binary Number");
            float m = float.Parse(Console.ReadLine());
            Program obj = new Program();
            obj.Convertbinary(n);
            obj.Convertbinary(m);
            // string sumOfTwoBinaryNum = Convert.ToString((firstBinaryNum + secondBinaryNum, 2));



        }
        public void Convertbinary(float num)
        {
            string a = num.ToString();
            string[] aList = a.Split(".");
            string Result = string.Empty;
            string[] binary = new string[0];
            foreach (string b in aList)
            {
                //Console.WriteLine(b);
                int number = int.Parse(b);

                for (int i = 0; number > 0; i++)
                {
                    Result = number % 2 + Result;
                    number = number / 2;
                }
                Console.WriteLine($"Binary Represenation of the given Number : {Result}");
                binary = binary.Append(Result).ToArray();
            }
            string z = string.Join(".", binary);
            decimal k = decimal.Parse(z);
            //return k;
            Console.WriteLine(z);
        }
    }
}
