using System;

namespace InterfaceEx_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("Hridoy","2051", "23/09/2019", 30000.00, 15000.00);
            t1.ShowTransaction();
            Console.WriteLine("\n");
            Transaction t2 = new Transaction("Hasan","2064","28/09/2020", 4000000.00, 40000.00);
            t2.ShowTransaction();
        }
    }
}
