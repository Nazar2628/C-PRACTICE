// This code defines a namespace named "assignment1"
namespace assignment1
{
    // This class named "Sub" is defined within the "assignment1"
    class Sub
    {
        // This line of code reads input from the user and stores it in a static string variable named "fullString"
        static string fullString = Console.ReadLine();

        // This line of code reads input from the user and stores it in a static string variable named "subString"
        static string subString = Console.ReadLine();

        // This method named "SubCount" is defined within the "Sub" class
        public void SubCount()
        {
            // These variables are initialized for counting the occurrence of the substring
            int i;
            int occuRance= 0; 
            int subString_Length = subString.Length;

            // This list named "ind" is initialized to store the indices where the substring occurs in the full string
            
            List<int> ind = new List<int>();

            // This for loop checks for the occurrence of the substring in the full string

            for ( i = 0; i < (fullString.Length - subString_Length)+1; i++)
            {
                if (fullString.Substring(i, subString_Length) == subString)
                {
                    // If the substring is found, the occurrence is incremented and the index is added to the list
                    
                    occuRance++;
                    ind.Add(i);
                }

            }

            // The number of times the substring occurred and the index positions are printed

            Console.WriteLine("No.of times occurred : " + occuRance);
            Console.WriteLine("Index positions : " + string.Join(" ", ind));
        }

        // This is the main method that will be executed when the program runs
        public static void Main(string[] args)
        {
            // An instance of the "Sub" class is created and the "SubCount" method is called

            Sub count =new Sub();
            count.SubCount();
        }

    }

}