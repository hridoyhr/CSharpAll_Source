using System;
using System.Collections.Generic;

namespace SearchAndSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.WorkWithString();

            var fibonacciNumbers = new List<int> { 1, 1};

            var previous = fibonacciNumbers[fibonacciNumbers.Count -1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count -2];

            fibonacciNumbers.Add(previous + previous2);

            foreach(var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        void WorkWithString()
        {
            var names = new List<string> { "Hridoy", "ZOZo", "Akbar", "ebraHIm" };
            names.Add("rezuawn");

            var index = names.IndexOf("Hasib");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");

            }
            Console.WriteLine($"Total Employee {names.Count}");
        }
    }
}
