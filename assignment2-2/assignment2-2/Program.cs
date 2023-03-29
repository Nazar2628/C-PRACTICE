namespace assignment
{
    class Highestcproduct
    {
        static String num = Console.ReadLine();

        public void highestproduct()
        {

            long largest = 0;
            List<string> substrings = new List<string>();
            List<string> K = new List<string>();
            List<string> L = new List<string>();

            for (int i = 0; i < num.Length - 4; i++)
            {


                String str_num = num.Substring(i, 4);
                substrings.Add(str_num);
            }
            foreach (string j in substrings)
            {
                int product = 1;
                foreach (char i in j)
                {
                    product = product * Int32.Parse(i.ToString());
                }
                if (product > largest)
                {
                    largest = product;
                    K.Add(j);
                }

            }
            foreach (char i in K.Last())
            {
                L.Add(i.ToString());
            }

            Console.WriteLine("output: " + string.Join("*", L) + " = " + largest);
        }
        public static void Main(string[] args)
        {
            Highestcproduct cou = new Highestcproduct();
            cou.highestproduct();
        }
    }
}