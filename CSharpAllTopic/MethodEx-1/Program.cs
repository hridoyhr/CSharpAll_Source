using System;

namespace MethodEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;

            NumberManipulator obj = new NumberManipulator();

            ret = obj.FindMax(a,b);
            Console.WriteLine(ret);
        }
    }
}
