
namespace CountOfSubString
{
    class CountOfSubString
    {
       
        /// <summary>
        /// This method named "SubCount" is defined to count the number of occurances of a substring of fullString 
        /// </summary>
        /// <param name="fullString"></param>
        /// <param name="subString"></param>
        public void SubCount(string fullString,string subString)
        {
           
            int i;
            int occurance= 0;
            int subString_Length = subString.Length;
            
            List<int> indexOfOccurance = new List<int>();

            for (i = 0; i < (fullString.Length - subString_Length) + 1; i++)
            {
                if (fullString.Substring(i, subString_Length) == subString)
                {

                    occurance++;
                    indexOfOccurance.Add(i);

                }

            }

            Console.WriteLine("No.of times occurred : " + occurance);
            Console.WriteLine("Index positions : " + string.Join(" ", indexOfOccurance));
        }

        // This is the main method that will be executed when the program runs
        public static void Main(string[] args)
        {
            string fullString = Console.ReadLine();
            string subString = Console.ReadLine();

            // An instance of the "Sub" class is created and the "SubCount" method is called

            CountOfSubString count =new CountOfSubString();
            count.SubCount(fullString,subString);
        }

    }

}