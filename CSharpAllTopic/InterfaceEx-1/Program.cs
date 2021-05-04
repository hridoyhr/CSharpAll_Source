using System;

namespace InterfaceEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.setWidth(4);
            rectangle.setHeight(4);

            Console.WriteLine("Area, {0}",rectangle.getArea());
        }
    }
}
