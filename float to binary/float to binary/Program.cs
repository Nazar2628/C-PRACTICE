
namespace FloattoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number : ");
            float binaryNUmber1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Binary Number");
            float binaryNumber2 = float.Parse(Console.ReadLine());
            Program obj = new Program();
            string firstBinayNum = obj.Convertbinary(binaryNUmber1);
            string secondBinaryNum = obj.Convertbinary(binaryNumber2);
            string bigString = obj.SplitBinary(firstBinayNum, secondBinaryNum);
            string[] dates = bigString.Split(',');
            string binaryValue = obj.AdditionOfBinary(dates[0], dates[1]);
            obj.ConvertBinaryToInteger(dates[2], binaryValue);
        }
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
        public string SplitBinary(string n, string m)
        {
            string[] dates = n.Split('.');
            string binary3 = dates[0];
            string binary1 = dates[1];
            string[] dates2 = m.Split('.');
            string binary4 = dates2[0];
            string binary2 = dates2[1];
            int number = int.Parse(binary3);
            List<string> ind = new List<string>();
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            int maxLength1 = Math.Max(binary3.Length, binary4.Length);
            while (binary1.Length < maxLength)
            {
                binary1 = "0" + binary1;
            }
            while (binary2.Length < maxLength)
            {
                binary2 = "0" + binary2;
            }
            while (binary3.Length < maxLength1)
            {
                binary3 = "0" + binary3;
            }
            while (binary4.Length < maxLength1)
            {
                binary4 = "0" + binary4;
            }
            ind.Add((binary3 + binary1));
            ind.Add((binary4 + binary2));
            ind.Add(binary1);
            return string.Join(",", ind);
        }
        public string AdditionOfBinary(string binary1, string binary2)
        {
            int maxLength = Math.Max(binary1.Length, binary2.Length);
            string result = "";
            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = carry;
                if (binary1[i] == '1')
                {
                    sum++;
                }
                if (binary2[i] == '1')
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
        public void ConvertBinaryToInteger(string mantissa, string binary)
        {
            int position = binary.Length - mantissa.Length;
            string binaryNumber = binary.Substring(0, position) + "." + binary.Substring(position);
            Console.WriteLine($"addition of two binaries is {binaryNumber}");
            string[] dates = binaryNumber.Split('.');
            string x1 = dates[0];
            string y1 = dates[1];
            int number = Convert.ToInt32(x1, 2);
            int number2 = Convert.ToInt32(y1, 2);
            string integer = number + "." + number2;
            Console.WriteLine($"addition of two numbers is {integer}");
        }
    }
}