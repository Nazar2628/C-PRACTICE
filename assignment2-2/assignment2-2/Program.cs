namespace Assignment
{
    class Highestproduct
    {
        static String longNumber = Console.ReadLine();

        public void highestproduct()
        {

            long largest = 0;
            List<string> subStrings = new List<string>();
            List<string> subsetList = new List<string>();
            List<string> L = new List<string>();

            for (int i = 0; i < longNumber.Length - 4; i++)
            {


                String str_num = longNumber.Substring(i, 4);
                subStrings.Add(str_num);
            }
            foreach (string j in subStrings)
            {
                int product = 1;
                foreach (char i in j)
                {
                    product = product * Int32.Parse(i.ToString());
                }
                if (product > largest)
                {
                    largest = product;
                    subsetList.Add(j);
                }

            }
            foreach (char i in subsetList.Last())
            {
                L.Add(i.ToString());
            }

            Console.WriteLine("output: " + string.Join("*", L) + " = " + largest);
        }
        public static void Main(string[] args)
        {
            Highestproduct Result = new Highestproduct();
            Result.highestproduct();
        }
    }
}