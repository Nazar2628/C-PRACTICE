namespace CartesianProduct
{
    class CartesianProduct
    {
        /// <summary>
                /// this method Highest product of four consecutive Number . 
                /// initially it will taake input as longNumber --> it makes subsets with length four --> making a list of highest product consecutive Numbers -->
                /// changing the largest product
                /// now join the elements of array through string.join method with "*"
                /// </summary>
                /// <param name="longNumber"></param>
                /// <returns></returns>
        /// 

        public void HighestProduct(string longNumber)
        {

            long largestProduct = 0;
            List<string> subStrings = new List<string>();
            List<string> highestProductList = new List<string>();
            List<string> highestProductValues = new List<string>();

            for (int i = 0; i < longNumber.Length - 3; i++)
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
                if (product > largestProduct)
                {
                    largestProduct = product;
                    highestProductList.Add(j);
                }

            }
            foreach (char i in highestProductList.Last())
            {
                highestProductValues.Add(i.ToString());
            }

            Console.WriteLine("output: " + string.Join("*", highestProductValues) + " = " + largestProduct);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the longNumber :");
            String longNumber = Console.ReadLine();
            CartesianProduct Result = new CartesianProduct();
            Result.HighestProduct(longNumber);
        }
    }
}