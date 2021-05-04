using System;

namespace enumEx_1
{
    class Program
    {
        enum dayList { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args)
        {
            int d1 = (int)dayList.Thu;
            Console.WriteLine(d1);

            

               
        }
    }
}
