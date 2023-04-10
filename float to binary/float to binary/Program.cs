
namespace FloatToBinary
{
    class FloatToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number : ");
            float binaryNumber1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Binary Number : ");
            float binaryNumber2 = float.Parse(Console.ReadLine());
            FloatToBinary obj = new FloatToBinary();
            string firstBinayNumber = obj.ConvertToBinary(binaryNumber1);
            string secondBinaryNumber = obj.ConvertToBinary(binaryNumber2);
            string splitingOfBinary = obj.SplitBinary(firstBinayNumber, secondBinaryNumber);
            string[] binaryValuesOfNumbers = splitingOfBinary.Split(',');
            string additionOfBinaryValue = obj.AdditionOfBinary(binaryValuesOfNumbers[0], binaryValuesOfNumbers[1]);
            obj.ConvertBinaryToInteger(binaryValuesOfNumbers[2], additionOfBinaryValue);
        }

        /// <summary>
                /// this method convert the numeric into a binary . 
                /// initially it will input as float number --> converts it into a string -->spliting a string from a dot -->
                /// now converting both exponent and decimallength of float number into binary separtely and appending this values in a array
                /// now join the elements of array through string.join method
                /// </summary>
                /// <param name="numeric"></param>
                /// <returns></returns>
                /// 
        public string ConvertToBinary(float num)
        {
            string stringNumber = num.ToString();
            string[] splitingNumber = stringNumber.Split(".");
            string Result = string.Empty;
            string[] binaryList = new string[0];
            foreach (string b in splitingNumber)
            {
                int number = int.Parse(b);
                for (int i = 0; number > 0; i++)
                {
                    Result = number % 2 + Result;
                    number = number / 2;
                }
                binaryList = binaryList.Append(Result).ToArray();
            }
            string binaryNumber = string.Join(".", binaryList);
            return binaryNumber;
        }

        /// <summary>
        /// initially need to split the firstBinary from a dot and assign it to a array1 and also need to perform same procedure to secondBinary
        /// through array index method , assign the binarystring elements into new strings which gives exponents and decimallesgth of float number
        /// now ordering both decimallength and exponents separetely of two binarystrings(adding 0 to binary such that both the lengths are need to be equal)
        /// now add this elements into new list
        /// </summary>
        /// <param name="firstBinaryNumber"></param>
        /// <param name="secondBinaryNumber"></param>
        /// <returns></returns>

        public string SplitBinary(string firstBinaryNumber, string secondBinaryNumber)
        {
            string[] firstBinary = firstBinaryNumber.Split('.');
            string firstIntegerBinary = firstBinary[0];
            string firstDecimalBinary = firstBinary[1];
            string[] secondBinary = secondBinaryNumber.Split('.');
            string secondIntergerBinary = secondBinary[0];
            string secondDecimalBinary = secondBinary[1];
            List<string> binaryValues = new List<string>();
            int maxLengthOfDecimal = Math.Max(firstDecimalBinary.Length, secondDecimalBinary.Length);
            int maxLengthOfInteger = Math.Max(firstIntegerBinary.Length, secondIntergerBinary.Length);
            while (firstDecimalBinary.Length < maxLengthOfDecimal)
            {
                firstDecimalBinary = "0" + firstDecimalBinary;
            }
            while (secondDecimalBinary.Length < maxLengthOfDecimal)
            {
                secondDecimalBinary = "0" + secondDecimalBinary;
            }
            while (firstIntegerBinary.Length < maxLengthOfInteger)
            {
                firstIntegerBinary = "0" + firstIntegerBinary;
            }
            while (secondIntergerBinary.Length < maxLengthOfInteger)
            {
                secondIntergerBinary = "0" + secondIntergerBinary;
            }
            binaryValues.Add((firstIntegerBinary + firstDecimalBinary));
            binaryValues.Add((secondIntergerBinary + secondDecimalBinary));
            binaryValues.Add(firstDecimalBinary);
            return string.Join(",", binaryValues);
        }

        /// <summary>
        /// this method defines the addition two binary strings
        /// </summary>
        /// <param name="binary1"></param>
        /// <param name="binary2"></param>
        /// <returns></returns>
        /// 
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

        /// <summary>
        /// here taking inputs are decimalLength of ordered binarystring  and binarystring
        /// through length of decimalLength , we can define the position of dot in binary string
        /// after adding dot at correct position, then we can split the string into two parts and can convert those into numeric
        /// and again join this numbers by dot 
        /// </summary>
        /// <param name="decimalLength"></param>
        /// <param name="binary"></param>
        public void ConvertBinaryToInteger(string decimalLength, string binary)
        {
            int position = binary.Length - decimalLength.Length;
            string binaryNumber = binary.Substring(0, position) + "." + binary.Substring(position);
            Console.WriteLine($"addition of two binaries is {binaryNumber}");
            string[] splitingTotalbinary = binaryNumber.Split('.');
            string totalIntergerValue = splitingTotalbinary[0];
            string totalDecimalValue = splitingTotalbinary[1];
            int number = Convert.ToInt32(totalIntergerValue, 2);
            int number2 = Convert.ToInt32(totalDecimalValue, 2);
            string integer = number + "." + number2;
            Console.WriteLine($"addition of two numbers is {integer}");
        }
    }
}