using System;

namespace ClassEx_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();

            box1.Length = 2.0;
            box1.Height = 2.0;
            box1.Width = 2.0;

            var rect = box1.getRec();
            Console.WriteLine(rect);


        }
    }
}
