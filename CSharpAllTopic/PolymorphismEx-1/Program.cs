using System;

namespace PolymorphismEx_1
{
    
    class Program
    {
       void Print(int i)
       {
            Console.WriteLine("Prtint int {0}", i);
       }
        void Print(double f)
        {
            Console.WriteLine("Prtint double = {0}", f);
        }
        void Print(string s)
        {
            Console.WriteLine("Prtint string = {0}", s);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Print(4);
            obj.Print(4.444);
            obj.Print("hello");
        }
    }
}
