using System;
using System.Text.RegularExpressions;

namespace Example_2
{
    class Program
    {
        private static void Showmatch(string text, string expr)
        {
            Console.WriteLine("The Expression", expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }

        }
        static void Main(string[] args)
        {
            string str = "A thousand Splendid Suns";

            Console.WriteLine("Mactching word 'S' ");
            Showmatch(str, @"\bs\S*");
        }
    }
}
