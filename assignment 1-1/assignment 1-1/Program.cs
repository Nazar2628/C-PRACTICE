namespace assignment1
{
    class Sub
    {
        
        static string a = Console.ReadLine();
        static string b = Console.ReadLine();

        public void subcount()
        {
            int i;
            int k = 0;
            int f = b.Length;
            List<int> ind = new List<int>();

            for (i = 0; i < (a.Length - f); i++)
            {
                if (a.Substring(i, f) == b)
                {
                    k++;
                    ind.Add(i);
                }

            }
            Console.WriteLine("No.of times occurred : " + k);
            Console.WriteLine("Index positions : " + string.Join(" ", ind));
        }
        public static void Main(string[] args)
        {
            Sub cou=new Sub();
            cou.subcount();
        }

    }

}