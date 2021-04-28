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
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}");
            //}
            //Console.WriteLine($"My name is {names[0]}");
            //Console.WriteLine($"I ve added {names[2]} and {names[3]} to list");
            //Console.WriteLine($"Total List {names.Count}");

            var index = names.IndexOf("Jakir");
            if(index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf return {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index{index}");
            }

            index = names.IndexOf("Not Found");
            if(index == -1)
            {
                Console.WriteLine($"When  an item is not found,Index of return {index}");
            }
            else
            {
                Console.WriteLine($"The name{names[index]} is at idex {index}");
            }
        }
    }
}
