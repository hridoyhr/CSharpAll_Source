using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx_2
{
    public class Box
    {
        public double Length;
        public double Height;
        public double Width;

        public void setLength(double len)
        {
            Length = len;
        }
        public void setHeight(double height)
        {
            Height = height;
        }
        public void setWidth(double width)
        {
            Width = width;
        }

        public double getRec()
        {
            return Length * Height * Width;
        }
    }
}
