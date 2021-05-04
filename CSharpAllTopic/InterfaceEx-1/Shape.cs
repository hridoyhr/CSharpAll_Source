using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx_1
{
    public class Shape
    {
        public void setWidth(int w)
        {
            Width = w;
        }
        public void setHeight(int h)
        {
            Width = h;
        }

        public int Width;
        public int Height;

    }
    public class Rectangle : Shape
    {
        public int getArea()
        {
            return Width* Height;
        }
        

        
    }
}
