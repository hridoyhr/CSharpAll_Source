using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEx_1
{
    class RectangleApplication
    {
        //members variable
        private double length;
        private double width;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public  void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Witdh: {0}",width);
            Console.WriteLine("Area: {0}",GetArea());
        }
    }
}
