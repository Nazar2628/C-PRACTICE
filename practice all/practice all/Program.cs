using System.Security.Cryptography;

namespace practice
{
    public class complex
    {
        private int i;
        private string k;
        public complex(int l=0,string o="")
        {
            i = l;
            k = o;
        }
        public static complex operator +(complex a, complex b)
        {
            complex o1 = new complex();
            o1.i = a.i + b.i;
            o1.k = a.k + b.k;
            return o1;
        }
        public void Display()
            {
                Console.WriteLine($"{i},{k}");
            }
        
        public static void Main(string[] args)
        {
            complex a = new complex(10, "NAZAR");
            a.Display();
            complex b = new complex(20, "Basha");
            b.Display();
            
            complex d = a + b;
            d.Display();
        }
        

    }
}