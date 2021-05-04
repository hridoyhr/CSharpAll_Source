using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex_2
{
    public class Rectangle
    {
        protected int Height;
        protected int Width;

        public void setValue(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public int GetArea()
        {
            return Height * Width;
        }

        public void Display()
        {
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    public class CostCalculating : Rectangle
    {
        public int getCoust()
        {
            return GetArea() * 70;
        }
        public void print()
        {
            Console.WriteLine("Total cost, {0}", getCoust());
        }
    }
    
}
