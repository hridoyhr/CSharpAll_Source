using System;

namespace EncapsulationEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPrivate CLass");
            RectangleApplication r = new RectangleApplication();
            r.AcceptDetails();
            r.Display();

            Console.WriteLine("\nPublic CLass");
            Reactangel2 r2 = new Reactangel2();
            r2.length = 4.5;
            r2.width = 4.5;
            r2.Display();

        }
    }
}
