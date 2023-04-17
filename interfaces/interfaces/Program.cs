using System.Security.Cryptography.X509Certificates;

namespace Interfaces
{
    interface InterfaceImplementation
    {
        public static string Name = "JSDBF";
        public void Add(int one,int two)
        {
            Console.WriteLine(one+ two);
        }
    }

    interface InterfaceImplementation1: InterfaceImplementation
    {
        public abstract void Mul(int one,int two)
        {

        }

        public void Sub(int one, int two)
        {
            Console.WriteLine(one - two);
        }
    }

    class Child : InterfaceImplementation1
    {
        
        public static void Main(string[] args)
        {
            Child child= new Child();
            child.Add(1,2);
            child.Sub(1,2);
        }
    }
}