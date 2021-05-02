using System;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.BandName = "Audi";
            obj.Color = "Black";
            obj.Price = 3000000;

            obj.maxSpedd();

            Console.WriteLine(obj.BandName);
            Console.WriteLine(obj.Color);
            Console.WriteLine(obj.Price);
        }
    }
}
