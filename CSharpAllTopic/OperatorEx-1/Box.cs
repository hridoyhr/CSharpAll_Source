using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx_1
{
    public class Box
    {
        private double Length;
        private double Width;
        private double Height;

        public double getVolume()
        {
            return Length * Width * Height;
        }

        public void SetLenght(double length)
        {
            Length = length;
        }
        public void setWidth(double width)
        {
            Width = Length;
        }
        public void setHeight(double height)
        {
            Height = height;
        }
    }
}
