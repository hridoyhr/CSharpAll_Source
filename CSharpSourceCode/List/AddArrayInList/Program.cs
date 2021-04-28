using System;
using System.Collections.Generic;

namespace AddArrayInList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[3] { "Dhaka", "Brasal", "Commilla" };

            var popularCities = new List<string>();

            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();
            favouriteCities.AddRange(popularCities);
            foreach(var print in favouriteCities)
            {
                Console.WriteLine(print);
            }
        }
    }
}
