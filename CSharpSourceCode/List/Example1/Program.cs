using System;
using System.Collections.Generic;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names =new List<string> { "Hasan","rakib","rony","Joy"};
            names.Remove("rony");
            names.Add("Rofiq");
            names.Add("Nabil");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I ve added {names[2]} and {names[3]} to list");
            Console.WriteLine($"Total List {names.Count}");
        }
    }
}
