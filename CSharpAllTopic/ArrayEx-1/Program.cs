using System;

namespace ArrayEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] blance = new double[10];
            blance[0] = 230000;
            blance[1] = 230000;
            blance[2] = 230000;

            foreach(var item in blance)
                Console.WriteLine(item);
            double[] amount = { 30,30,20,20,90,29};
            Console.WriteLine(amount[3]);
        }
    }
}
