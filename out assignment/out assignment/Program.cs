using System.Threading;
namespace outparameter
{
    class Outparameter

    {
        string k = "6565246";
        int l;
        //static int q = 0;


        //public string name(ref string n)
        //{
        //    k = "6562";
        //    return k;

        //}
        //public int inte(ref int q)
        //{
        //    dynamic Result = Int32.TryParse(k, out q) ? q : k;
        //    return Result;
        //}



        public dynamic cov()
        {
            dynamic Result = Int32.TryParse(k, out l) ? l : k;
            return Result;
        }


        //public string name1(out string k)
        //{  
        //    k = " fejrjr";
        //    return k;
        //}
        public static void Main(string[] args)
        {
            //string m;
            Outparameter m = new Outparameter();
            //m.name1(out string k );
            //l.name(ref k);
            //Console.WriteLine(m);
            //l.inte(ref q);
            //Console.WriteLine(k);
            Console.WriteLine(m.l);
            m.cov();
            Console.WriteLine(m.l);

        }
    }
}