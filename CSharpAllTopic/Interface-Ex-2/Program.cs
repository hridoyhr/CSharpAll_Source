using System;

namespace Interface_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CostCalculating obj = new CostCalculating();
            obj.setValue(4,4);
            obj.print();
            obj.Display();
        }
    }
}
