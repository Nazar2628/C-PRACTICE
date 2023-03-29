
using System.Text;

namespace FloattoBinary
{
    class Program
    {

        static float n = float.Parse(Console.ReadLine());
        static float m = float.Parse(Console.ReadLine());


        public string Convertbinary(float num)
        {
            string a = num.ToString();
            string[] aList = a.Split(".");
            string Result = string.Empty;
            string[] binary = new string[0];
            foreach (string b in aList)
            {
                int number = int.Parse(b);

                for (int i = 0; number > 0; i++)
                {
                    Result = number % 2 + Result;
                    number = number / 2;
                }
                binary = binary.Append(Result).ToArray();
            }
            string z = string.Join(".", binary);
            return z;
        }

        public static void Main(string[] args)
        {
            Program obj = new Program();
            string a = obj.Convertbinary(n);
            string b = obj.Convertbinary(m);
            string addbinary = obj.addbinary(a, b);
            float o = n + m;
            Console.WriteLine("Binary code of m is {0}", a);
            Console.WriteLine("Binary code of n is {0}", b);
            Console.WriteLine("Result of adding two binary is {0}", obj.Convertbinary(o));
            Console.WriteLine("Binary to Float value is {0} ", o);
        }
        public string addbinary(string a, string b)
        {
            int maxLength = Math.Max(a.Length, b.Length);
            string result = "";
            int carry = 0;
            while (a.Length < maxLength)
            {
                a = "0" + a;
            }
            while (b.Length < maxLength)
            {
                b = "0" + b;
            }
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = carry;
                if (a[i] == '1')
                {
                    sum++;
                }
                if (b[i] == '1')
                {
                    sum++;
                }
                if (sum >= 2)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                result = (sum % 2).ToString() + result;
            }
            if (carry == 1)
            {
                result = "1" + result;
            }
            return result;

        }
    }
}

